using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreNameSetMessage))]
    public partial interface IStoreNameSetMessage : IMessage
    {
        ILocalizedString Name { get; set; }

        IList<ILocalizedString> NameAllLocales { get; set; }
        IEnumerable<ILocalizedString> NameAllLocalesEnumerable { set => NameAllLocales = value.ToList(); }


    }
}