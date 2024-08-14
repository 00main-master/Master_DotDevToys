namespace Master_DotDevToys
{
    public class Program
    {
        public string s { get; set; }
        static void Main(string[] args) => new Program()._Main();
        private void _Main() 
        {
            s = "ABOBA";
            Viewer.Snapshot(this);
            while (true)
            {
                Console.WriteLine($"{((int)Console.ReadKey().Key)}");
            }
        }
    }
}
