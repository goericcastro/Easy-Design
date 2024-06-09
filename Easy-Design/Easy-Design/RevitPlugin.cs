using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using System.Windows.Forms;

namespace Easy_Design
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class RevitPlugin : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("EasyDesign"); //PRINCIPAL MENU

                MessageBox.Show("Firstplug");
                application.CreateRibbonPanel("EasyDesign", "Edit Level"); //SECONDS MENUS, HERE IS THE BOTTOM FOR ACTIVATE THE PLUGIN
                
                
                application.CreateRibbonPanel("EasyDesign", "Menu 1"); //SECONDS MENUS, HERE IS THE BOTTOM FOR ACTIVATE THE PLUGIN

                application.CreateRibbonPanel("EasyDesign", "Menu 2"); //SECONDS MENUS, HERE IS THE BOTTOM FOR ACTIVATE THE PLUGIN

            return Result.Succeeded;
        }
    }
}
