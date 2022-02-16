namespace RPG.Execptions
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException()
        {
        }

        public InvalidWeaponException(string message)
            : base(message)
        {
        }

        public InvalidWeaponException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
