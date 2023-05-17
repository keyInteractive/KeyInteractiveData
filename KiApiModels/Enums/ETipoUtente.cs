using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiApiModels.Enums;

public enum ETipoUtente
{
    [Description("Utente")]
    Utente = 0,

    [Description("Cliente")]
    Cliente = 1,
}
