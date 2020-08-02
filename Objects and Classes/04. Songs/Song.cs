namespace _04._Songs
{
    internal class Song
    {
        public Song()
        {

        }

        public string Name { get; internal set; }
        public string TypeList { get; internal set; }
      
        public string Time { get; internal set; }

        public void Print() { this; }
    }
}