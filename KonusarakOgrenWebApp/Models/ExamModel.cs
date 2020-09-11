using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenWebApp.Models
{
    public class ExamModel
    {
        public int SınavId { get; set; }
        public string SoruBaslik { get; set; }
        public string SoruAciklama { get; set; }
        public string SoruBir { get; set; }
        public string SoruIki { get; set; }
        public string SoruUc { get; set; }
        public string SoruDort { get; set; }
        public string DogruCevap { get; set; }
    }
}
