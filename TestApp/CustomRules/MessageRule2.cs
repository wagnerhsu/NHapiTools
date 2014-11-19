﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapiTools.Base;
using NHapiTools.Base.Validation;

namespace TestApp.CustomRules
{
    public class MessageRule2 : ISpecificMessageRule
    {
        public string[] GetVersions()
        {
            return new string[] { "2.3", "2.4" };
        }
        
        public string[] GetMessageTypes()
        {
            return new string[] { "ADT" };
        }

        public string[] GetTriggerEvents()
        {
            return new string[] { "A08" };
        }

        public NHapi.Base.validation.ValidationException[] test(NHapi.Base.Model.IMessage msg)
        {
            return new NHapi.Base.validation.ValidationException[0];
        }

        public string Description
        {
            get { return string.Empty; }
        }

        public string SectionReference
        {
            get { return string.Empty; }
        }
    }
}
