namespace CompositeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var box1 = new Box("Box 1");
            var candybox = new Box("CandyBox");
            var bookbundle = new Box("BookBundle");

            box1.AddItem(candybox);
            candybox.AddItem(new Product("Chocolate", 2.5m)); // Price Weight
            candybox.AddItem(new Product("Gummy Bears", 1.5m));

            box1.AddItem(bookbundle);
            bookbundle.AddItem(new Product("The Color of Magic", 12.66m));
            bookbundle.AddItem(new Product("Anti-Oedipus", 18.99m));
            bookbundle.AddItem(new Product("Staying with the Trouble", 27.44m));

            bookbundle.AddItem(new Product("The Order of Things", 14.99m));

            box1.Display(1);
        }
    }
}
