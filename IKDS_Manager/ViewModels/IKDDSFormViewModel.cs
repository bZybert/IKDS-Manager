using IKDDS_Manager.Models;
using IKDS_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IKDDS_Manager.ViewModels
{
    public class IKDDSFormViewModel
    {
        public IKDDSModel IKDDSModel { get; set; }
        public IEnumerable<InvestigationType> InvestigationType;
        //public IEnumerable<InvestigationInitiateType> investigationInitiateTypes;

    }
}
