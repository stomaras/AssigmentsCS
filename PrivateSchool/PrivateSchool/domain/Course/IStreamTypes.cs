using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.domain.Course
{
    interface IStreamTypes
    {

        List<string> InitializeStreamTypes(int min, int max);
    }
}
