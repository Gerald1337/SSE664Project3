using System;
using System.Text.RegularExpressions;

public class PasswordVerifier
{
	public PasswordVerifier()
	{
	}

    /// <summary>
    /// Whether or not the given password is usable.
    /// Passwords must contain a number and be at least 8 characters.
    /// </summary>
    /// <param name="password">The password to validate.</param>
    /// <returns>True if the password is valid.</returns>
    public static bool IsValidPassword(String password)
    {
        // Contains at least one number
        if (!Regex.IsMatch(password, @"\d"))
        {
            return false;
        }
        // Required length of at least 8
        return password.Length >= 8;
    }

}
