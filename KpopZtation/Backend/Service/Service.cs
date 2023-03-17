using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Facade;

namespace KpopZtation.Backend.Service
{
    public class Service
    {
        public static string WSLogin(string Email, string Password)
        {
            return Json.Encode(AuthController.Login(Email, Password));
        }
        public static string WSRegister(string Name, string Email, string Gender, string Address, string Password)
        {
            return Json.Encode(AuthController.Register(Name, Email, Gender, Address, Password));
        }
        public static string WSGetArtists()
        {
            return Json.Encode(ArtistController.GetArtists());
        }
        public static string WSGetArtistByID(int id)
        {
            return Json.Encode(ArtistController.FindById(id));
        }
    }
}