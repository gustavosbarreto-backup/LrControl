﻿using LrControlApi.Common;

namespace LrControlApi.Modules.LrSelection
{
    public class Flag : ClassEnum<int, Flag>
    {
        public static readonly Flag None = new Flag(0, "None");
        public static readonly Flag Pick = new Flag(1, "Pick");
        public static readonly Flag Reject = new Flag(-1, "Reject");

        static Flag()
        {
            AddEnums(None,Pick,Reject);
        }
        
        private Flag(int value, string name) : base(value, name)
        {
        }
    }
}