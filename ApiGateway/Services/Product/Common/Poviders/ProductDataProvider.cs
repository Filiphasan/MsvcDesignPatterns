namespace Product.Common.Poviders;

public class ProductDataProvider
{
    private static readonly Lazy<ProductDataProvider> _instance = new(() => new ProductDataProvider());
    public static ProductDataProvider Instance => _instance.Value;

    // Its not thread safe but its ok for this demo
    private readonly List<Entities.Product> _products = [];

    public List<Entities.Product> GetProducts()
    {
        return _products;
    }

    public Entities.Product GetProduct(int id)
    {
        return _products.Find(x => x.Id == id);
    }

    public void AddProduct(Entities.Product product)
    {
        if (product.Id == 0)
        {
            var lastId = _products.MaxBy(x => x.Id)?.Id ?? 0;
            product.Id = lastId + 1;
        }
        _products.Add(product);
    }

    public void RemoveProduct(Entities.Product product)
    {
        _products.Remove(product);
    }

    public void UpdateProduct(Entities.Product product)
    {
        var updatedProduct = _products.Find(x => x.Id == product.Id);
        if (updatedProduct is not null)
        {
            _products.Remove(updatedProduct);
        }
        AddProduct(product);
    }
}