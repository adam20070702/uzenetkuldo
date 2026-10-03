using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzenetkuldo.Models;

namespace uzenetkuldo.Interfaces
{
    public interface ICRUD
    {
        string Create(Tablazat tablazat);
        List<Tablazat> Read();
        string Update(Tablazat tablazat);
        string Delete(int Id);
    }
}
