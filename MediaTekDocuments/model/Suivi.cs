﻿using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Suivi (réunit les informations des classes Public, Genre et Rayon)
    /// </summary>
    public class Suivi
    {
        public string Id { get; }
        public string Stade { get; }
        public string IdLivreDvd { get; }

        public Suivi(string id, string stade, string idLivreDvd)
        {
            this.Id = id;
            this.Stade = stade;
            this.IdLivreDvd = idLivreDvd;
        }
    }
}