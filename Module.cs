using System.Windows.Forms;

namespace ionInjectorZ
{
    public class Module
    {
       public void InjectDLL(string _proc, string _dll)
        {
            switch (DLLInjection.DllInjector.GetInstance.Inject(_proc, _dll))
            {
                case DLLInjection.DllInjectionResult.DllNotFound:
                    int num1 = (int)MessageBox.Show("Couldn't find the dll!", "Error: Dll Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case DLLInjection.DllInjectionResult.GameProcessNotFound:
                    int num2 = (int)MessageBox.Show("Process does not exist", "Apllication Process Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case DLLInjection.DllInjectionResult.InjectionFailed:
                    int num3 = (int)MessageBox.Show("Injection failed! :(", "Injection Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case DLLInjection.DllInjectionResult.Success:
                    int num4 = (int)MessageBox.Show("Successfully Injected The Dll", "Injection Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }
        }
    }
}

