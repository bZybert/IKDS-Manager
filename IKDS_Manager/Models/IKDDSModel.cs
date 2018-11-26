using IKDDS_Manager.Models;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
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

        [Required(ErrorMessage = "Pole IKD.DS jest wymagane")]
        [Display(Name = "Numer IKD.DS.560.")]
        public string IKDDS { get; set; }

        [Required]
        [Display(Name = "Policjant prowadzący")]
        public string OfficerName { get; set; }

        [Display(Name = "Typ postępowania")]
        public InvestigationType InvestigationType { get; set; }


        /*  

       public InvestigationInitiateType InvestigationInitiateType { get; set; }

       [Display(Name = "Tok postępowania")]
       public byte InvestigationInitiateTypeId { get; set; }
 */
        [Display(Name = "Numer RSD-I")]
        public string RsdNumber { get; set; }

        [Display(Name = "Numer RPS-I")]
        public string RpsNumber { get; set; }

        [Required]
        [Display(Name = "Data wszczęcia")]
        public DateTime EntryData { get; set; }

        [Display(Name = "Przewidywana data zakończenia")]
        public DateTime FinalData { get; set; }


        [Display(Name = "Połączenie postępowań")]
        public bool JoinWithOtherInvestigation { get; set; }

        [Display(Name = "Decyzja")]
        public string FinalOfInvestigation { get; set; }

        [Display(Name = "Data wprowadzenia do systemu")]
        public DateTime AddedInSystem { get; set; }

        [Display(Name = "Data O.Z.")]
        public DateTime? OZDate { get; set; }

        [Display(Name = "Data zakończenia")]
        public DateTime? RealEndDate { get; set; }

        [Display(Name = "Kwalifikacja prawna")]
        public string ArticleNumber { get; set; }




    }
}
