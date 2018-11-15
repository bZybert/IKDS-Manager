using IKDDS_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IKDS_Manager.Models
{
    public class IKDDSModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Numer IKD.DS.560.")]
        public string IKDDS { get; set; }

        [Required]
        [Display(Name = "Policjant prowadzący")]
        public string OfficerName { get; set; } = "Janik";
                
        public InvestigationType InvestigationType { get; set; }

        [Required]
        [Display(Name = "Rodzaj postępowania")]
        public byte? InvestigationTypeId { get; set; }

        
        public InvestigationInitiateType InvestigationInitiateType { get; set; }

        [Display(Name = "Tok postępowania")]
        public byte InvestigationInitiateTypeId { get; set; }

        [Display(Name = "Numer RSD-I")]
        public string RsdNumber { get; set; }

        [Display(Name = "Numer RPS-I")]
        public string RpsNumber { get; set; }

        [Display(Name = "Data wszczęcia")]
        public DateTime EntryData { get; set; } = default(DateTime);

        [Display(Name = "Data zakończenia")]
        public DateTime FinalData { get; set; }
        
        /*
        [Display(Name = "Zwrot z prokuratury")]
        public bool ProsecutorsReturn { get; set; }

        [Display(Name = "Przedłużenie postępowania")]
        public bool Prolongate { get; set; }

        [Display(Name = "Zakończono postępowanie")]
        public bool Closed { get; set; }
        */
        [Display(Name = "Połączenie postępowań")]
        public bool JoinWithOtherInvestigation { get; set; }



        [Display(Name = "Decyzja")]
        public string FinalOfInvestigation { get; set; }
    }
}
