using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lexique.Data
{
    [Table("lexique", Schema = "lexique")]
    public class Lexique
    {
        [Key]
        public string Ortho { get; set; }
        public string Phon { get; set; }
        public string Lemme { get; set; }
        public string Cgram { get; set; }
        public string Genre { get; set; }
        public string Nombre { get; set; }
        public float Freqlemfilms { get; set; }
        public float Freqlemlivres { get; set; }
        public float Freqfilms { get; set; }
        public float Freqlivres { get; set; }
        public string Infover { get; set; }
        public int Nbhomogr { get; set; }
        public int Nbhomoph { get; set; }
        public bool Islem { get; set; }
        public int Nblettres { get; set; }
        public int Nbphons { get; set; }
        public string Cvcv { get; set; }
        public string P_cvcv { get; set; }
        public int Voisorth { get; set; }
        public int Voisphon { get; set; }
        public int Puorth { get; set; }
        public int Puphon { get; set; }
        public string Syll { get; set; }
        public int Nbsyll { get; set; }
        public string Cv_cv { get; set; }
        public string Orthrenv { get; set; }
        public string Phonrenv { get; set; }
        public string Orthosyll { get; set; }
    }
}
