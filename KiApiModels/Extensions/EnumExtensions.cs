using KiApiModels.Classes;
using KiApiModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiApiModels.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// Ottiene tutte le nazioni di EState
    /// </summary>
    /// <returns></returns>
    public static List<NationsList> GetNations()
    {
        List<NationsList> nations = new(); 

        foreach (EState country in (EState[])Enum.GetValues(typeof(EState)))
        {
            NationsList nation = new()
            {
                EnumValue = (int)country,
                Description = GetEnumDescription(country),
            };

            nations.Add(nation);
        }

        return nations;
    }

    private static string GetEnumDescription(this Enum enumValue)
    {
        var descriptionAttribute = enumValue.GetType()
            .GetField(enumValue.ToString())
            .GetCustomAttributes(false)
            .SingleOrDefault(attr => attr.GetType() == typeof(DescriptionAttribute)) as DescriptionAttribute;

        // return description
        return descriptionAttribute?.Description ?? "";
    }
}
