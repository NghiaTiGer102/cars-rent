using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarNew.Utils
{
    public class DataProvider
    {
        private static DataProvider ins;
        public static DataProvider Ins
        {
            get
            {
                if (ins == null)
                {
                    ins = new DataProvider();
                }
                return ins;
            }
            set
            {
                ins = value;
            }
        }
        public ShiftEntities DB { get; set; }
        public DataProvider()
        {
            DB = new ShiftEntities();
        }
    }
}