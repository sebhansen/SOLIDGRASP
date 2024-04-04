using System;

/*
 * This class manages user related stuff.
 * Here we show Single Responsibility by having the class focus on a single aspect of the system
 * which is user management.
 */
public class UserService
{
    public void RegisterUser(string username, string password)
    {
        // Imagine some logic for user registration
    }

    public void AuthenticateUser(string username, string password)
    {
        // Imagine some logic for authentication of user
    }

    public void UpdateUserProfile(string username, UserProfile userProfile)
    {
        // Imagine some logic for User profile update
    }
}


///////////////////////////////////////////////////////////////////////////////
public class UserProfile;