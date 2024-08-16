using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class FTP
    {
        public int test;
        public static FTP Ftp { get; } = new FTP();

        private FTP()
        {
            test = 5;
        }

    }
}