using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Alinhamento
    {
        [Display(Name = "LEAL E BOM")]
        LEAL_E_BOM = 1,

        [Display(Name = "LEAL E NEUTRO")]
        LEAL_E_NEUTRO = 2,

        [Display(Name = "LEAL E MAU")]
        LEAL_E_MAU = 3,

        [Display(Name = "NEUTRO E BOM")]
        NEUTRO_E_BOM = 4,

        [Display(Name = "NEUTRO")]
        NEUTRO = 5,

        [Display(Name = "NEUTRO E MAU")]
        NEUTRO_E_MAU = 6,

        [Display(Name = "CAÓTICO E BOM")]
        CAOTICO_E_BOM = 7,

        [Display(Name = "CAÓTICO E NEUTRO")]
        CAOTICO_E_NEUTRO = 8,

        [Display(Name = "CAÓTICO E MAU")]
        CAOTICO_E_MAU = 9
        
    }
}
