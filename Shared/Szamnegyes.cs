namespace Shared
{
    public class Szamnegyes
    {
        public Guid Id { get; set; }
        public int[] ints { get; set; }

        public Szamnegyes()
        {
            Id = Guid.NewGuid();
            ints = new int[4];
        }

    }
}
