using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Homework
{
    internal class WrongNumberException:Exception
    {
        public WrongNumberException(string message)
        : base(message)
        {

        }
    }
}
