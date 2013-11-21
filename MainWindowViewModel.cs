using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
  public class MainWindowViewModel
  {
    public string Greeging
    {
      get
      {
        return "Hello!";
      }
    }
    public event EventHandler Hide;

    public void HideWindow()
    {
      var handler = Hide;
      if (handler != null)
      {
        handler(this, EventArgs.Empty);
      }
    }
  }
}
