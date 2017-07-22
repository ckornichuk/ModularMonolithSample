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
        public ItemModule(IItemService service)
        {
            Get["/item/"] = _ =>
            {
                return Response.AsJson(service.GetItems());
            };

            Get["/item/{id:int}"] = item =>
            {
                return service.GetItem(item.id);
            };

            Post["/item/"] = item =>
            {
                ItemDto dto = this.Bind<ItemDto>();

                if (string.IsNullOrEmpty(dto.Name))
                    return HttpStatusCode.BadRequest;

                if (!service.IsItemNameUnique(dto.Name))
                    return HttpStatusCode.Conflict;

                service.InsertItem(dto);

                return HttpStatusCode.OK;
            };
        }
    }
}
