﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panda.EmaraSystem.BO
{
   public class SessionQuestion
   {
       public int SessionQuestionId { get; set; }
       public int SessionId { get; set; }
       public string Question { get; set; }
       public string Answer { get; set; }
    }
}