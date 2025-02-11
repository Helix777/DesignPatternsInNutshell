namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.AddCPU();
            _builder.AddMotherboard();
            _builder.AddRAM();
        }
    }
}