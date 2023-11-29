using System.Text.RegularExpressions;

namespace Store.Statics
{
    public static class Validation
    {
        public static bool ValidateName(string firstName)
        {
            // Name should not be empty and should only contain letters.
            return !string.IsNullOrWhiteSpace(firstName) && Regex.IsMatch(firstName, @"^[A-Za-z]+$");
        }

        public static bool ValidateEmail(string email)
        {
            // Basic email validation using a regular expression.
            return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Basic phone number validation.
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        public static bool ValidateUsername(string username)
        {
            // Username should not be empty and should only contain letters, numbers, and underscores.
            return !string.IsNullOrWhiteSpace(username) && Regex.IsMatch(username, @"^[A-Za-z0-9_]+$");
        }

        public static bool ValidatePassword(string password)
        {
            // Password is not empty and has at least 8 characters.
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 8;
        }


        // FOR PAYMENT METHODS =============================================================================
        public static bool ValidateNameOnCard(string firstName)
        {
            // Name should not be empty and should contain letters and spaces.
            return !string.IsNullOrWhiteSpace(firstName) && Regex.IsMatch(firstName, @"^[A-Za-z\s]+$");
        }

        public static bool ValidateCardNumber(string cardNumber)
        {
            // Card number validation.
            return !string.IsNullOrWhiteSpace(cardNumber) && Regex.IsMatch(cardNumber, @"^\d{16}$");
        }

        public static bool ValidateExpiryDate(string expiryDate)
        {
            // Expiry date validation.
            return !string.IsNullOrWhiteSpace(expiryDate) && Regex.IsMatch(expiryDate, @"^(0[1-9]|1[0-2])\/\d{2}$");
        }

        public static bool ValidateSecurityCode(string securityCode)
        {
            // Security code validation.
            return !string.IsNullOrWhiteSpace(securityCode) && Regex.IsMatch(securityCode, @"^\d{3}$");
        }

        public static bool ValidatePostCode(string postcode)
        {
            // Post code validation for 4 to 5 digits.
            return !string.IsNullOrWhiteSpace(postcode) && Regex.IsMatch(postcode, @"^\d{4,5}$");
        }

        // FOR SHIPPING METHODS =============================================================================
        public static bool ValidateAddress(string address)
        {
            // Address should not be empty.
            return !string.IsNullOrWhiteSpace(address);
        }

        public static bool ValidateCity(string city)
        {
            // City should not be empty and should only contain letters.
            return !string.IsNullOrWhiteSpace(city) && Regex.IsMatch(city, @"^[A-Za-z\s]+$");
        }

        public static bool ValidateState(string state)
        {
            // State should not be empty and should only contain letters.
            return !string.IsNullOrWhiteSpace(state) && Regex.IsMatch(state, @"^[A-Za-z\s]+$");
        }

        public static bool ValidateCountry(string country)
        {
            // Country should not be empty and should only contain letters.
            return !string.IsNullOrWhiteSpace(country) && Regex.IsMatch(country, @"^[A-Za-z\s]+$");
        }
    }
}
