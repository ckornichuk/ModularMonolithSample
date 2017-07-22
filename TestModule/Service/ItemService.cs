using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Command;
using TestModule.Projection;

namespace TestModule.Service
{
    public class ItemService : IItemService
    {
        private GetItemQuery _getItemQuery = new GetItemQuery();
        private InsertItemCommand _insertItemCommand = new InsertItemCommand();
        private ListItemsQuery _listItemsQuery = new ListItemsQuery();
        private CheckUniqueNameQuery _uniqueNameQuery = new CheckUniqueNameQuery();
        
        public ItemDto GetItem(int id)
        {
            return _getItemQuery.Execute(id);
        }

        public IEnumerable<ItemDto> GetItems()
        {
            return _listItemsQuery.Execute();
        }

        public void InsertItem(ItemDto item)
        {
            _insertItemCommand.Execute(item);
        }

        public bool IsItemNameUnique(string name)
        {
            return _uniqueNameQuery.Execute(name);
        }
    }
}
