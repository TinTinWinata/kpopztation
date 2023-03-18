﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Handler;
using KpopZtation.Backend.Facade;
using System.Web.UI.WebControls;

namespace KpopZtation.Backend.Controller
{

    public class ArtistController
    {
        public static List<Artist> GetArtists()
        {
            return ArtistHandler.GetArtists();
        }



        public static Data<Artist> CreateArtist(string Username, FileUpload FileImage, HttpServerUtility Server)
        {
            string ImagePath = File.SaveFile(FileImage, Server);

            Artist Object = ArtistHandler.Create(Username, ImagePath);

            return new Data<Artist>("Succesfully Create Artist!", Object, true);
        }

        public static Artist FindById(int id)
        {
            return ArtistHandler.FindById(id);
        }
    }
}