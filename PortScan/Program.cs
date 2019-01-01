using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Sockets;

namespace ConsolePortScanner
{
    class MainClass
    {
        public static int Main(string[] args)
        {
            int returnCode = 0;

            try
            {
                var task = RunPortScanAsync();
                task.Wait();
            }
            catch (Exception ex)
            {
                returnCode = 1;

                Console.WriteLine("  error : {0}",
                    ex.InnerException != null
                        ? ex.InnerException.Message
                        : ex.Message);
            }

            if (returnCode == 0)
            {
                Console.WriteLine("Finished.");
            }

            return returnCode;
        }

        public static async Task RunPortScanAsync()
        {
            // do a specific range
            Console.WriteLine("> Checking ports 75-85 on localhost...\n");
            PortScanner cps = new PortScanner("163.172.182.7", 52700, 58000);

            var progress = new Progress<PortScanner.PortScanResult>();
            progress.ProgressChanged += (sender, args) =>
            {
                Console.WriteLine(
                    $"Port {args.PortNum} is " +
                    $"{(args.IsPortOpen ? "open" : "closed")}");
            };

            await cps.ScanAsync(progress);
            cps.LastPortScanSummary();

            // do the local machine, whole port range 1-65535
            //cps = new CheapoPortScanner();
            //await cps.Scan(progress);
            //cps.LastPortScanSummary();
        }
    }

    /// <summary>
    /// Use Sockets to Scan the Ports on a Machine.
    /// </summary>
    /// <remarks>
    /// From the Oreilly C# 6.0 Cookbook
    /// https://github.com/oreillymedia/c_sharp_6_cookbook
    /// http://shop.oreilly.com/product/0636920037347.do
    /// </remarks>
    internal class PortScanner
    {
        private const int PORT_MIN_VALUE = 1;
        private const int PORT_MAX_VALUE = 65535;

        private List<int> _openPorts;
        private List<int> _closedPorts;

        public ReadOnlyCollection<int> OpenPorts => new ReadOnlyCollection<int>(_openPorts);
        public ReadOnlyCollection<int> ClosedPorts => new ReadOnlyCollection<int>(_closedPorts);

        public int MinPort { get; } = PORT_MIN_VALUE;
        public int MaxPort { get; } = PORT_MAX_VALUE;

        public string Host { get; } = "127.0.0.1"; // localhost

        public PortScanner()
        {
            // defaults are already set for ports & localhost
            SetupLists();
        }

        public PortScanner(string host, int minPort, int maxPort)
        {
            if (minPort > maxPort)
                throw new ArgumentException("Min port cannot be greater than max port");

            if (minPort < PORT_MIN_VALUE || minPort > PORT_MAX_VALUE)
                throw new ArgumentOutOfRangeException(
                    $"Min port cannot be less than {PORT_MIN_VALUE} " +
                    $"or greater than {PORT_MAX_VALUE}");

            if (maxPort < PORT_MIN_VALUE || maxPort > PORT_MAX_VALUE)
                throw new ArgumentOutOfRangeException(
                    $"Max port cannot be less than {PORT_MIN_VALUE} " +
                    $"or greater than {PORT_MAX_VALUE}");

            Host = host;
            MinPort = minPort;
            MaxPort = maxPort;

            SetupLists();
        }

        private void SetupLists()
        {
            // set up lists with capacity to hold half of range
            // since we can't know how many ports are going to be open
            // so we compromise and allocate enough for half

            // rangeCount is max - min + 1
            int rangeCount = (MaxPort - MinPort) + 1;

            // if there are an odd number, bump by one to get one extra slot
            if (rangeCount % 2 != 0)
            {
                rangeCount += 1;
            }

            // reserve half the ports in the range for each
            _openPorts = new List<int>(rangeCount / 2);
            _closedPorts = new List<int>(rangeCount / 2);
        }

        internal class PortScanResult
        {
            public int PortNum { get; set; }
            public bool IsPortOpen { get; set; }
        }

        private async Task CheckPortAsync(int port, IProgress<PortScanResult> progress)
        {
            if (await IsPortOpenAsync(port))
            {
                // if we got here it is open
                _openPorts.Add(port);

                // notify anyone paying attention
                progress?.Report(new PortScanResult { PortNum = port, IsPortOpen = true });
            }
            else
            {
                // server doesn't have that port open
                _closedPorts.Add(port);
                progress?.Report(new PortScanResult() { PortNum = port, IsPortOpen = false });
            }
        }

        private async Task<bool> IsPortOpenAsync(int port)
        {
            Socket socket = null;

            try
            {
                // make a TCP based socket
                socket = new Socket(AddressFamily.InterNetwork, SocketType
                    .Stream, ProtocolType.Tcp);

                // connect
                await Task.Run(() => socket.Connect(Host, port));

                return true;
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.ConnectionRefused)
                {
                    return false;
                }

                //An error occurred when attempting to access the socket
                Debug.WriteLine(ex.ToString());
                Console.WriteLine(ex);
            }
            finally
            {
                if (socket?.Connected ?? false)
                {
                    socket?.Disconnect(false);
                }
                socket?.Close();
            }

            return false;
        }

        public async Task ScanAsync(IProgress<PortScanResult> progress)
        {
            for (int port = MinPort; port <= MaxPort; port++)
                await CheckPortAsync(port, progress);
        }

        public void LastPortScanSummary()
        {
            // display "0" or comma delimited list of open ports
            string openPorts = (_openPorts.Count == 0)
                ? "0"
                : string.Join(",", _openPorts);

            // display "0" or comma delimited list of closed ports
            string closedPorts = (_closedPorts.Count == 0)
                ? "0"
                : string.Join(",", _closedPorts);

            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine("Port Scan Results");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine($"Open Ports......: {openPorts}");
            Console.WriteLine($"Closed Ports....: {closedPorts}");
            Console.WriteLine();
        }
    }
}