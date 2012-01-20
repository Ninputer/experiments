using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cloo;

namespace LinqToGpuTest
{
    public class Accelerator
    {
        private ComputeDevice m_device;

        public static Accelerator Default
        {
            get
            {
                return null;
            }
        }

        public AcceleratorView DirectView
        {
            get
            {
                return null;
            }
        }
    }
}
