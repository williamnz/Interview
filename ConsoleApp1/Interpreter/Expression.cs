using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interpreter
{
    public interface Expression
    {
        bool Interpret(string context);
    }
}
