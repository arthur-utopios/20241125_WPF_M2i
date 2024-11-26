using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace Demo04Theme
{
    public class AppThemeSelector
    {
        public static void ChangeTheme(Uri themeUri)
        {
            // On va récupérer un thème
            ResourceDictionary themeDictionary = new ResourceDictionary() { Source = themeUri };

            // Ici on supprime les ressources existantes
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(themeDictionary);

        }
    }
}
