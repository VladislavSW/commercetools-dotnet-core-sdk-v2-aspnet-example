using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TaxRate))]
    public partial interface ITaxRate
    {
        string Id { get; set; }

        string Name { get; set; }

        int Amount { get; set; }

        bool IncludedInPrice { get; set; }

        string Country { get; set; }

        string State { get; set; }

        IList<ISubRate> SubRates { get; set; }
        IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


    }
}