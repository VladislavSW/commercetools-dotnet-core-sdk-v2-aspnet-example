using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceExternalDiscountSetMessagePayload))]
    public partial interface IProductPriceExternalDiscountSetMessagePayload : IMessagePayload
    {
        int VariantId { get; set; }

        string VariantKey { get; set; }

        string Sku { get; set; }

        string PriceId { get; set; }

        IDiscountedPrice Discounted { get; set; }

        bool Staged { get; set; }

    }
}
