﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_test_git.ChainOfRespo
{
    public class CeoHandler:AbstractHandler
    {
        public override LvlApprovazione Handle(LvlApprovazione request)
        {
            if (request.Equals(LvlApprovazione.CEO))
            {
                return request;
            }
            return base.Handle(request);
        }
    }
}
