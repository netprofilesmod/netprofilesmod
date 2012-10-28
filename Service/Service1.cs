using System;
using System.Collections;
using System.Threading;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

using AppModule.InterProcessComm;
using AppModule.NamedPipes;

namespace Service
{
    public partial class Service1 : ServiceBase
    {
        public static IChannelManager PipeManager;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            PipeManager = new PipeManager();
            PipeManager.Initialize();
        }

        protected override void OnStop()
        {
            if (PipeManager != null)
            {
                PipeManager.Stop();
            }
        }
    }

}
