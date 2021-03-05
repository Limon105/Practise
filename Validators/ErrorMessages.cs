namespace Practise.Validators
{
    public static class ErrorMessages
    {
        public static string userNameErrorIsEmpty = "Name is empty";

        public static string userNameErrorMinimumLength = "Name must be at least two characters long.";

        public static string userNameErrorMaximumLenght = "Name must have a maximum of 50 characters.";

        public static string userNameErrorMustBeValidName = "Name must contain only letters.";

        public static string userPasswordErrorEmpty = "Password is empty";

        public static string userPasswordErrorMinimumLenght = "Password must be at least eight characters long.";

        public static string userPasswordErrorMaximumLenght = "Password must be no more than 16 characters.";

        public static string userPasswordErrorMatches = "The Password must consist of numbers and letters, and contain at least one lowercase and one uppercase letter";

        public static string userConfirmPasswordErrorEmpty = "ConfirmPassword is empty";

        public static string userConfirmPasswordErrorMinimumLenght = "ConfirmPassword must be at least eight characters long.";

        public static string userConfirmPasswordErrorMaximumLenght = "ConfirmPassword must be no more than 16 characters.";

        public static string userConfirmPasswordErrorMatches = "The ConfirmPassword must consist of numbers and letters, and contain at least one lowercase and one uppercase letter";

        public static string userConfirmPasswordErrorEqualPasword = "Passwords mismatch";
    }
}
