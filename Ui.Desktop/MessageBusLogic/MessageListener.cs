﻿using De.HsFlensburg.ClientApp048.Logic.Ui.MessageBusMessages;
using De.HsFlensburg.ClientApp048.Services.MessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp048.Ui.Desktop.MessageBusLogic
{
    class MessageListener
    {

        public bool BindableProperty => true;

        public MessageListener()
        {
            InitMessenger();
        }

        private void InitMessenger()
        {
            ServiceBus.Instance.Register<OpenNewClientWindowMessage>(this, OpenNewClientWindow);
        }

        private void OpenNewClientWindow()
        {
            NewClientWindow myWindow = new NewClientWindow();
            myWindow.ShowDialog();
        }
    }
}
