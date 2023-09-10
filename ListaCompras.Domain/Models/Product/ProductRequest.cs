namespace ListaCompras.Domain.Models.Product
{
    public class ProductRequest : ProductBase
    {
        public ProductRequest()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}