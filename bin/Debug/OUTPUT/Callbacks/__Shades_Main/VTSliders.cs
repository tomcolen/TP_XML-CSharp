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

using myNamespace.Constants;

namespace myNamespace.Methods
{
    public class __Shades_MainVTSliders
    {
        public __Shades_MainVTSliders(Panel Panel)
        {
            this.Panel = Panel;
        }
/*
        private bool BaseSanityCheck
        {
            get
            {
                if (CableBox != ControlSystem.GetSystem._cableBox)
                {
                    CableBox = ControlSystem.GetSystem._cableBox;
                }
                return CableBox != null;
            }
        }
*/
		
        public void LiquidGaugeVertical(VTSlider Slider)
        {
            throw new NotImplementedException();

            //
            //{
            //   
            //
            //
            //}

        }

        public void LiquidGaugeVertical_1(VTSlider Slider)
        {
            throw new NotImplementedException();

            //
            //{
            //   
            //
            //
            //}

        }

        public void LiquidGaugeVertical_2(VTSlider Slider)
        {
            throw new NotImplementedException();

            //
            //{
            //   
            //
            //
            //}

        }


        private Panel Panel;
        private IBasicCableBox CableBox;
    }
}