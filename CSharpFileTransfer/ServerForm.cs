﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UtilityLibrary;

namespace FileTransferServer {
    public partial class CSFTServer : Form {
        const string DIRECTORY_PATH = "E:\\AI\\";
        const string SERVER_IP = "10.5.104.70";
        const int PORT = 5000;

        // int key : string filename + filesize
        private Dictionary<int, string> dirFiles = new Dictionary<int, string>();

        // Thread signal.  
        public ManualResetEvent allDone = new ManualResetEvent(false);

        public CSFTServer() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public class StateObject {
            public const int BufferSize = 1024; // Size of receive buffer.
            public byte[] buffer = new byte[BufferSize]; // Receive buffer.
            public StringBuilder sb = new StringBuilder(); // Received data string.
            public Socket workSocket = null; // Client socket.
        }

        // Server will start waiting for a connection using the SERVER_IP and PORT
        public void StartListening() {
            IPAddress ipAddress = IPAddress.Parse(SERVER_IP);
            IPEndPoint localEndpoint = new IPEndPoint(ipAddress, PORT);

            // Create a TCP/IP socket.
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try {
                listener.Bind(localEndpoint);
                listener.Listen(100);

                while (true) {
                    // Set the event to nonsignaled state.
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.
                    Console.WriteLine("[s]: Waiting for a connection...");
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);

                    // Wait until a connection is made before continuing.
                    allDone.WaitOne();
                }
            } catch (Exception e) {
                Console.WriteLine("StartListening Error: {0}", e.ToString());
            }

        }

        public void AcceptCallback(IAsyncResult ar) {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.
            StateObject state = new StateObject {
                workSocket = handler
            };
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar) {
            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket.
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0) {
                String data = Encoding.ASCII.GetString(state.buffer, 0,
                    bytesRead);

                if (data != "!quit") {
                    Console.WriteLine("[s] Data : {0}", data);

                    // After logging in, send list of file inside the DIRECTORY_PATH
                    if (data.StartsWith(":log:")) {

                        // change the label in the ServerForm to connected.
                        // MethodInvoker is used here to change the label because this part is being run in a separate thread.
                        MethodInvoker inv = delegate {
                            lblClientConnected.Text = "Client Connected.";
                        };
                        Invoke(inv);

                        if (Directory.Exists(DIRECTORY_PATH)) {

                            int count = 1;
                            foreach (string filename in Directory.GetFiles(DIRECTORY_PATH)) {
                                FileInfo fileInfo = new FileInfo(filename);
                                dirFiles.Add(count, Path.GetFileName(filename) + ":" + fileInfo.Length);
                                count++;
                            }

                            // process to send the dirFiles dictionary back to the client
                            UtilityLibrary.Message message = SerialLibrary.Serialize(dirFiles);
                            Send(handler, message);
                        }
                    } else {
                        // this part is when the client request for file download
                        string filepath = DIRECTORY_PATH + dirFiles[int.Parse(data)].Split(':')[0];
                        Console.WriteLine("initiate send file: {0}", filepath);
                        handler.SendFile(filepath);
                        
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                } else {
                    Console.WriteLine("[s] Quit Signal : {0}", data);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
        }

        public void Send(Socket handler, UtilityLibrary.Message message) {
            // Begin sending the data to the remote device.
            handler.BeginSend(message.Data, 0, message.Data.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar) {
            try {
                // Retrieve the socket from the state object.
                Socket handler = (Socket) ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("SendCallback: Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            } catch (Exception e) {
                Console.WriteLine("SendCallback: {0}", e.ToString());
            }
        }

        // StartListening() method will start in a new thread when start button is clicked
        private void btnStart_Click(object sender, EventArgs e) {
            btnStart.Enabled = false;
            btnStart.Text = "Listening...";
            Thread serverThread = new Thread(new ThreadStart(StartListening));
            serverThread.Start();
        }

        private void CSFTServer_Load(object sender, EventArgs e)
        {

        }
    }
}
