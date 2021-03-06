﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHouse.Interfaces;
using SmartHouse.States;

namespace SmartHouse.Devices
{
    class Garage : Device, IOpenable
    {
        private OpenState openState;
        public OpenState OpenState
        {
            get
            {
                return openState;
            }

        }

        public void Open()
        {

            openState = OpenState.Open;
            
        }

        public void Close()
        {
            openState = OpenState.Close;
        }
        

    }
}
