using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Bootstrap {
    static void Main(string[] args) {
        var cultureId = CultureInfo.GetCultureInfo("en-us").LCID;

        var collection = new System.Drawing.Text.InstalledFontCollection();
        var families = collection.Families;
        foreach(var f in families) {
            Console.WriteLine(f.GetName(cultureId));
        }
    }
}