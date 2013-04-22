
namespace NerdDinner.Helpers
{
    using System.Configuration;
    using Microsoft.WindowsAzure.ServiceRuntime;

    public static class ConnectionStringResolver
    {
        public static string NerdDinnerEntities
        {
            get
            {
                return (RoleEnvironment.IsAvailable)
                           ? RoleEnvironment.GetConfigurationSettingValue("NerdDinnerEntities")
                           : ConfigurationManager.ConnectionStrings["NerdDinnerEntities"].ConnectionString;
            }
        }
    }
}