﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panda.EmaraSystem.BO
{
    public enum CaseStatus
    {
        opened =1 ,
        closed = 0,
        onhold = 2,//only when waiting client enagagment
    }
}
