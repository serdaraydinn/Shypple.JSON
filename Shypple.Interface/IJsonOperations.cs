using Shypple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Interface
{
    public interface IJsonOperations
    {
        string ReadJsonAsString(string path);
        Root GetRootObject(string jsonText);
        void WriteJson(SailingOutput root, string fileName);
        void WriteJson(List<SailingOutput> y, string v);
    }
}
