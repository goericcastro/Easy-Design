using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Autodesk.Revit.UI;

using System.Reflection;
using System.Windows.Media.Imaging;


namespace EasyDesign
{
    public class MenuApp : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            RibbonPanel panel = RibbonPanel(application);


            return Result.Succeeded;
        }

        public RibbonPanel RibbonPanel(UIControlledApplication application)
        {
            string tab = "EasyDesign";
            RibbonPanel ribbonPanel = null;
            try
            {
                application.CreateRibbonTab(tab);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            try
            {
                application.CreateRibbonPanel(tab, "ARCHITECTURE");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            List<RibbonPanel> panels = application.GetRibbonPanels(tab);
            foreach (RibbonPanel p in panels.Where(p => p.Name == "Arch"))
            {
                ribbonPanel = p;
            }
            return ribbonPanel;
        }
    }
}
