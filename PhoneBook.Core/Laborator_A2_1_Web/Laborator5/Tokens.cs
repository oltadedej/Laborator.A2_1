using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laborator_A2_1_Web.Laborator5
{
    public static class Tokens
    {

        //useri i loguar ne sistem
        //merret sessioni dhe konvertohet ne nje objekt te tipit user
        // nuk ruaj vec usernamen ruaj komplet objektin user ne session
        public static User LoggedUser
        {
            get
            {
                if (HttpContext.Current.Session["User"] != null)
                    return (User)HttpContext.Current.Session["User"];

                else
                {
                    return null;

                };
            }

            set
            {
                if (LoggedUser != null)
                {
                    HttpContext.Current.Session["User"] = (User)HttpContext.Current.Session["User"];
                }
            }
        }

        public static List<Authorization> UserAuthorization
        {
            get
            {
                if (HttpContext.Current.Session["UserAuthorization"] == null)
                {
                    using (University1Entities dbcontext = new University1Entities())
                    {
                        var results = from user_authorz in dbcontext.User_Authorization
                                      join authoriz in dbcontext.Authorizations on user_authorz.AuthorizationId equals authoriz.AuthorizationId

                                      where user_authorz.UserId == LoggedUser.UserId
                                      select authoriz;

                        HttpContext.Current.Session["UserAuthorization"] = results.ToList<Authorization>();
                    }

                }
                return (List<Authorization>)HttpContext.Current.Session["UserAuthorization"];

            }
        }


        //rasti kur keni tabelen user_authorization
        public static bool IsAdmin
        {
            get
            {
                if (UserAuthorization != null)
                {
                    HttpContext.Current.Session["IsAdmin"] = UserAuthorization.Any(i => i.Description.Equals("Admin"));
                }
                return (bool)HttpContext.Current.Session["IsAdmin"];
            }
        }



        //rasti kur keni ndarjen e adminit dhe readerit me role

        //public static bool IsAdminWithRoles
        //{
        //    get
        //    {
        //        if (LoggedUser != null)
        //        {
        //            HttpContext.Current.Session["IsAdmin"] = (bool)LoggedUser.Role;
        //        }
        //        return (bool)HttpContext.Current.Session["IsAdmin"];
        //    }
        //}



    }
}