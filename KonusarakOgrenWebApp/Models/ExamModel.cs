using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenWebApp.Models
{
    public class ExamModel
    {
        [Key]
        public int SınavId { get; set; }
        public string SoruBaslik { get; set; }
        public string SoruAciklama { get; set; }
        public string SoruBir { get; set; }
        public string SecenekBirA { get; set; }
        public string SecenekBirB { get; set; }
        public string SecenekBirC { get; set; }
        public string SecenekBirD { get; set; }
        public string SoruIki { get; set; }
        public string SecenekIkiA { get; set; }
        public string SecenekIkiB { get; set; }
        public string SecenekIkiC { get; set; }
        public string SecenekIkiD { get; set; }
        public string SoruUc { get; set; }
        public string SecenekUcA { get; set; }
        public string SecenekUcB { get; set; }
        public string SecenekUcC { get; set; }
        public string SecenekUcD { get; set; }
        public string SoruDort { get; set; }
        public string SecenekDortA { get; set; }
        public string SecenekDortB { get; set; }
        public string SecenekDortC { get; set; }
        public string SecenekDortD { get; set; }
        public string DogruCevapBir { get; set; }
        public string DogruCevapIki { get; set; }
        public string DogruCevapUc { get; set; }
        public string DogruCevapDort { get; set; }
    }
}
