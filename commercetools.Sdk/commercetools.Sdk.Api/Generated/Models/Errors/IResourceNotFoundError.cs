using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ResourceNotFoundError))]
    public partial interface IResourceNotFoundError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
