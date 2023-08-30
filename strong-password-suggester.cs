using System;
using System.Text;
using System.Linq;

class GFG {

    static string GenerateRandomPassword(int length, string validChars) {
        Random random = new Random();
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++) {
            int randomIndex = random.Next(validChars.Length);
            password.Append(validChars[randomIndex]);
        }

        return password.ToString();
    }

    static string GenerateStrongPassword(string password) {
        int lowercaseFlag = 0, uppercaseFlag = 0, digitFlag = 0, specialCharFlag = 0;

        foreach (char c in password) {
            if (char.IsLower(c)) lowercaseFlag = 1;
            else if (char.IsUpper(c)) uppercaseFlag = 1;
            else if (char.IsDigit(c)) digitFlag = 1;
            else specialCharFlag = 1;
        }

        if ((lowercaseFlag + uppercaseFlag + digitFlag + specialCharFlag) == 4) {
            return "Your Password is Strong\n";
        }
        else {
            string validChars = "";
            if (lowercaseFlag == 0) validChars += "abcdefghijklmnopqrstuvwxyz";
            if (uppercaseFlag == 0) validChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (digitFlag == 0) validChars += "0123456789";
            if (specialCharFlag == 0) validChars += "@#$_()!";

            string suggestedPassword = GenerateRandomPassword(8, validChars);
            return suggestedPassword;
        }
    }

    public static void Main() {
        string input_string = "raashid@2002"; // Change this to your desired password
        string result = GenerateStrongPassword(input_string);
        Console.WriteLine("Input Password: " + input_string);
        Console.WriteLine("Suggested Password:");
        Console.WriteLine(result);
    }
}
