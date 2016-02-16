﻿using LrControlApi.Common;

// ReSharper disable InconsistentNaming

namespace LrControlApi.Modules.LrDevelopController
{
    public class ProcessVersion : ClassEnum<string, ProcessVersion>
    {
        public static readonly ProcessVersion PV2003 = new ProcessVersion("2003");
        public static readonly ProcessVersion PV2010 = new ProcessVersion("2010");
        public static readonly ProcessVersion PV2012 = new ProcessVersion("2012");

        static ProcessVersion()
        {
            AddEnums(PV2003, PV2010, PV2012);
        }

        private ProcessVersion(string name) : base(name, name)
        {
        }
    }
}