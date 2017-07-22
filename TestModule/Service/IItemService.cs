using System.Collections.Generic;
using TestModule.Projection;

namespace TestModule.Service
{
    public interface IItemService
    {
        ItemDto GetItem(int id);
        IEnumerable<ItemDto> GetItems();
        void InsertItem(ItemDto item);
        bool IsItemNameUnique(string name);
    }
}