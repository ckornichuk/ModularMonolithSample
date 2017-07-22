using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Projection;
using TestModule.Service;

namespace ModularMonolithSample.Module
{
    public class ItemModule : Nancy.NancyModule
    {
        private IItemService _service = new ItemService();

        public ItemModule()
        {
            Get["/item/"] = _ =>
            {
                return Response.AsJson(_service.GetItems());
            };

            Get["/item/{id:int}"] = item =>
            {
                return _service.GetItem(item.id);
            };

            Post["/item/"] = item =>
            {
                ItemDto dto = this.Bind<ItemDto>();

                if (string.IsNullOrEmpty(dto.Name))
                    return HttpStatusCode.BadRequest;

                if (!_service.IsItemNameUnique(dto.Name))
                    return HttpStatusCode.Conflict;

                _service.InsertItem(dto);

                return HttpStatusCode.OK;
            };
        }
    }
}
