using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laborator_A2_1_Web.Laborator5
{
    public static class Tokens
    {
        public static User User
        {
            get
            {
                if (HttpContext.Current.Session["User"] != null) return (User)(HttpContext.Current.Session["User"]);
                else return null;
            }
            set
            {
                if (User != null)
                    HttpContext.Current.Session["User"] = (User)HttpContext.Current.Session["User"];

            }
        }

        public static List<Authorization> User_Authorizations
        {
            get
            {
                if (HttpContext.Current.Session["User_Authorizations"] == null)
                {
                    using (University1Entities dbcontext = new University1Entities())
                    {
                        var results = from user_authorizaton in dbcontext.User_Authorization
                                      join authorization
                                        in dbcontext.Authorizations on user_authorizaton.AuthorizationId equals authorization.AuthorizationId
                                      where user_authorizaton.UserId == User.UserId
                                      select authorization;
                        HttpContext.Current.Session["User_Authorizations"] = results.ToList<Authorization>();

                    }
                }
                return (List<Authorization>)(HttpContext.Current.Session["User_Authorizations"]);
            }
        }


        public static bool IsAdmin
        {
            get
            {
                if (User_Authorizations != null)
                {
                    HttpContext.Current.Session["IsAdmin"] = User_Authorizations.Any(i => i.Description.Equals("Admin"));
                }
                return (bool)(HttpContext.Current.Session["IsAdmin"]);
            }
        }

    }
}