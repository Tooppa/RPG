namespace RPG.Execptions {
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }

        public InvalidArmorException(string message)
            : base(message)
        {
        }

        public InvalidArmorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    } 
}
