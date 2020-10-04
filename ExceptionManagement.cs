using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMetal
{
    class ExceptionManagement
    {
        public static void HandleException(Action action)
        {
			try
			{
                action.Invoke();
			}
			catch (FormatException)
			{
                MessageBox.Show("Girdiğiniz değerlerden biri uygun formatta değil. Kontrol ediniz!");
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
