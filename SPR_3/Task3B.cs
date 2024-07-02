using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPR_3;

public class Task3B : Task3A
{
    public override int Task3(int x, int y)
    {        
        return (int)Math.Pow(base.Task3(x, y), 2);
    }
}
