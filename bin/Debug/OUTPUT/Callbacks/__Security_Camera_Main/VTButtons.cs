using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Crestron.SimplSharp;

using Crestron.ThirdPartyCommon.Class;
using Crestron.ThirdPartyCommon.ComponentInterfaces;
using Crestron.ThirdPartyCommon.Interfaces;
using Crestron.ThirdPartyCommon.StandardCommands;
using Crestron.ThirdPartyCommon.Transports;

using VTPro.Objects;
using VTPro.SmartObjects;

using myNamespace.Drivers;

using myNamespace.Constants;

namespace myNamespace.Methods
{
    public class __Security_Camera_MainVTButtons
    {
        public __Security_Camera_MainVTButtons(Panel Panel)
        {
            this.Panel = Panel;
        }
/*
        private bool BaseSanityCheck
        {
            get
            {
                if (Bluray != ControlSystem.GetSystem._blurayPlayer)
                {
                    Bluray = ControlSystem.GetSystem._blurayPlayer;
                }
                return Bluray != null;
            }
        }
*/
		
        public void Button(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Simple_Button(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        public void Simple_Button_1(VTButton Button, bool IsPressed)
        {
            if (IsPressed)
            {
                //press function here
                throw new NotImplementedException();

            }
        }

        
        

        
        
        public IBasicBlurayPlayer Bluray;
        private Panel Panel;
    }
}