namespace ESC_POS_USB_NET.Interfaces.Command {
  using System;
  using System.Collections.Generic;
  using System.Text;

  interface IEnableZHCNMode {
    byte[] EnableZHCNMode();
    byte[] DisableZHCNMode();
  }
}
