namespace Singleton
{
    public class Singletonn
    {
        private Singletonn() {}
        
        private static Singletonn _instance;
        
        public static Singletonn GetInstance()
        {
            return _instance ??= new Singletonn();
        }
    }
}