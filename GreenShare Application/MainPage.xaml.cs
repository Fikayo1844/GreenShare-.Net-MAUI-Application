namespace GreenShare_Application;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSignInClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Perform validation
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            DisplayAlert("Error", "Username and password are required", "OK");
            return;
        }

        // Check username and password against a database or authentication service
        bool isAuthenticated = AuthenticateUser(username, password);

        if (isAuthenticated)
        {
            // Navigate to the Main page or another page upon successful sign-in
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            DisplayAlert("Error", "Invalid username or password", "OK");
        }
    }

    private bool AuthenticateUser(string username, string password)
    {
        // Dummy authentication logic (Actual authentication mechanism yet to come)
        // Assuming a hardcoded username and password for demonstration purposes
        const string validUsername = "user123";
        const string validPassword = "password123";

        return (username == validUsername && password == validPassword);
    }

    private void OnSignUpTapped(object sender, EventArgs e)
    {
        // Navigate to the sign-up page
        Navigation.PushAsync(new SignUpPage());
    }
}

