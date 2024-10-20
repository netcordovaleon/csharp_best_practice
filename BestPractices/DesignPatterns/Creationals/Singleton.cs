namespace BestPractices.DesignPatterns.Creationals
{
    public class Singleton
    {
        static Singleton _instance;

        public static Singleton GetInstance() {
            if (_instance == null) { 
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
