using Shypple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Interface
{
    public interface ISailingOperations
    {
        SailingOutput GetCheapestDirectSailing(Root rootObject);

        List<SailingOutput> GetCheapestSailingLegs(Root rootObject);

        List<SailingOutput> GetFastestSailingLegs(Root rootObject);
    }
}
