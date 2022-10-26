using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoEF
{
    public static class MesajKutusu
    {
        public static DialogResult Goster(string caption, string message,MessageBoxButtons buttons=MessageBoxButtons.OK) 
        {
            MB mB = new MB(caption,message,buttons);
            DialogResult result = mB.ShowDialog();
           return  result;
        }
        
    }
}
