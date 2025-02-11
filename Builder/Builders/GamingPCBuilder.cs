namespace Builder.Builders
{
    public class GamingPCBuilder : IBuilder
    {
        private CustomedPC _product = new CustomedPC();

        public void AddCPU()
        {
            _product.Part1 = "I5 6400";
        }

        public void AddMotherboard()
        {
            _product.Part2 = "H110";
        }

        public void AddRAM()
        {
            _product.Part3 = "32GB DDR4";
        }

        public CustomedPC GetProduct()
        {
            return _product;
        }
    }
}