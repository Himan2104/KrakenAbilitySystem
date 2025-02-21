namespace Kraken.AbilitySystem
{
    public class Tag
    {
        internal string _name = "Unknown";
        public string Name => _name;
    }
    
    public static class TagManager
    {
        private static Tag[] s_Tags;
        
    }
}