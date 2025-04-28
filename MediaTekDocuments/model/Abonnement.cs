using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Abonnement (réunit les informations des classes Public, Genre et Rayon)
    /// </summary>
    public class Abonnement
    {
        public string Id { get; }
        public DateTime DateFinAbonnement { get; }
        public string IdRevue { get; }
        public string IdCommande { get; private set; }
        public DateTime DateCommande { get; private set; }
        public double Montant { get; private set; }

        public Abonnement(string id, DateTime dateFinAbonnement, string idRevue, Commande commande)
        {
            this.Id = id;
            this.DateFinAbonnement = dateFinAbonnement;
            this.IdRevue = idRevue;
        }

        public void CompleterAvecCommande(Commande commande)
        {
            this.IdCommande = commande.Id;
            this.DateCommande = commande.DateCommande;
            this.Montant = commande.Montant;
        }
    }
}