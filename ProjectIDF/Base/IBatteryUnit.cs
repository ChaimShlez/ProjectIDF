﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF.Base
{
    internal interface IBatteryUnit
    {
        int Battery { get;  }
        void Recharge();
    }
}
