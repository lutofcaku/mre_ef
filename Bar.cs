namespace MinimalReproducibleExample
{
    public sealed class Bar
    {
        public int Id { get; set; }
        public BarUniqueId BarUniqueId { get; set; }
    }

    public sealed class BarUniqueId
    {
        public int BarId { get; set; }
    }
}
