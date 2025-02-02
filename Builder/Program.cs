using Builder;

class Program
{
    static void Main(string[] args)
    {
        // Czyli builder dostarcza interfejs do tworzenia obiektów, a director decyduje w jakiej kolejności mają być wywoływane metody buildera
        IBuilder builder = new Builder.Builders.GamingPCBuilder();
        Director director = new Director(builder);

        director.Construct();
        CustomedPC product = builder.GetProduct();

        product.Display();
    }
}



