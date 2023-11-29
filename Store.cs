using Store.Structs;

namespace Store
{
    public class Store
    {
        public HomePage homePage; // Homepage that is always active
        public UserData userData; // UserData of the logged in user
        public DataParser dataParser; // All the data parsed 

        /// <summary>
        /// Seperate Init() function that is not called in constructor due to Application Constraints
        /// </summary>
        public void Init()
        {
            dataParser = new DataParser();
            homePage = (HomePage)new HomePage().SetFormProperties();
        }

        /// <summary>
        /// Show the HomePage
        /// </summary>
        /// <param name="currentForm"></param>
        public void ShowHomePage(Form currentForm)
        {
            if (userData.IsValid() && userData.UserRole.Equals(UserRoles.Customer))
            {
                dataParser.RetrieveCartDataList();
            }

            homePage.SetFormProperties(currentForm);

            homePage.InitializeHomePage();

            homePage.Show();
            homePage.Focus();
        }

        /// <summary>
        /// On FormClosed Call this method so all resources are closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseEnvironment(object? sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }


        /// <summary>
        /// Set userData of the logged in user
        /// </summary>
        /// <param name="uData"></param>
        public void SetUserData(UserData uData)
        {
            this.userData = uData;
        }

        /// <summary>
        /// Get userData of the logged in user
        /// </summary>
        /// <returns></returns>
        public UserData GetUserData()
        {
            return userData;
        }
    }
}
