namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        // Lazy<T>
        /// <summary>
        /// Compiler makes this thread-safe
        /// Will construc the method passed once the lazyLogger value property is accessed
        /// </summary>
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        //private static Logger? _instance;

        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }
        }

        /// <summary>
        /// Cannot be instantiated by clients but can be sub-classed
        /// </summary>
        protected Logger()
        {
        }

        /// <summary>
        /// SingletonOperation
        /// </summary>
        /// <param name="message">Takes the string passed to the Log method and writes it to the console</param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }

}
