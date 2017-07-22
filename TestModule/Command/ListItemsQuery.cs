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
    class ListItemsQuery
    {
        private ItemMapper mapper = new ItemMapper();

        internal IEnumerable<ItemDto> Execute()
        {
            using (var context = new ItemContext())
            {
                return mapper.MapManyToDto(context.Items);
            }
        }
    }
}
