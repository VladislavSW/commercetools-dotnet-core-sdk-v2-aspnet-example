namespace commercetools.Sdk.ImportApi.Client
{
    public interface ISecured_by_view_productsTrait<T> where T : ISecured_by_view_productsTrait<T>
    {



        ISecured_by_view_productsTrait<T> AsSecured_by_view_productsTrait()
        {
            return this;
        }

        T AsSecured_by_view_productsTraitToBaseType()
        {
            return (T)this;
        }
    }
}
