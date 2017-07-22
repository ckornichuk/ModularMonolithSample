using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Projection;
using TestModule.Mapper;
using TestModule.Model;

namespace TestModule.Command
{
    class InsertItemCommand
    {
        private ItemMapper mapper = new ItemMapper();

        internal void Execute(ItemDto item)
        {
            using (var context = new ItemContext())
            {
                context.Items.Add(mapper.MapToEntity(item));

                context.SaveChanges();
            }
        }
    }
}
