﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver()
        {

        }
        public ActionResolver(ActionRequest actionRequest,MessageLogger messageLogger)
        {

        }
        public ActionResponse Execute(ActionRequest request)
        {
            switch(request)
                {
                case Convertion:

                    break;
                case Uppercase:

                    break;
                case Reverse:

                    break;
            }

                return null;
            
        }
    }
}
