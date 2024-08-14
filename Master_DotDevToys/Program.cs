namespace Master_DotDevToys
{
    internal class Program
    {
        public string s { get; set; }
        static void Main(string[] args) => new Program()._Main();
        private void _Main() 
        {
            s = "ABOBA";
            Viewer.Snapshot(this);
        }
    }
}
