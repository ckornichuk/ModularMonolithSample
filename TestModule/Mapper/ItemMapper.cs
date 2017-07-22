using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Projection;
using TestModule.Model;

namespace TestModule.Mapper
{
    class ItemMapper
    {
        internal ItemDto MapToDto(Item item)
        {
            return new ItemDto()
            {
                Id = item.Id,
                Name = item.Name,
            };
        }

        internal Item MapToEntity(ItemDto item)
        {
            return new Item()
            {
                Id = item.Id,
                Name = item.Name,
            };
        }

        internal IEnumerable<ItemDto> MapManyToDto(IEnumerable<Item> items)
        {
            List<ItemDto> dtos = new List<ItemDto>();
            foreach (var item in items)
            {
                dtos.Add(new ItemDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                });
            }

            return dtos;
        }
    }
}
