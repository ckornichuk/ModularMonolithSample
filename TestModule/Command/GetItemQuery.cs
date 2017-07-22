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
    class GetItemQuery
    {
        private ItemMapper mapper = new ItemMapper();

        internal ItemDto Execute(int id)
        {
            using (var context = new ItemContext())
            {
                return mapper.MapToDto(context.Items.Where(i => i.Id == id).FirstOrDefault());
            }
        }
    }
}
