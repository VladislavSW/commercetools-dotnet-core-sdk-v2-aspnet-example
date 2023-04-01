using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPublishedMessagePayload))]
    public partial interface IProductPublishedMessagePayload : IMessagePayload
    {
        IList<string> RemovedImageUrls { get; set; }
        IEnumerable<string> RemovedImageUrlsEnumerable { set => RemovedImageUrls = value.ToList(); }


        IProductProjection ProductProjection { get; set; }

        IProductPublishScope Scope { get; set; }

    }
}
