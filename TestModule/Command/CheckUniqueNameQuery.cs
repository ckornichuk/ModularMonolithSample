using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Model;

namespace TestModule.Command
{
    class CheckUniqueNameQuery
    {
        internal bool Execute(string name)
        {
            using (var context = new ItemContext())
            {
                return !context.Items.Any(i => i.Name == name);
            }
        }
    }
}
