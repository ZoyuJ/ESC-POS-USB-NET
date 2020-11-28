namespace ESC_POS_USB_NET.Printer {
  using System;
  using System.Collections.Generic;
  using System.Text;

  using ESC_POS_USB_NET.Interfaces.Command;
  using ESC_POS_USB_NET.ZH_CNExtension_GB2312;

  public class Printer_ZHCN : Printer {
    public Printer_ZHCN(string PrinterName, string codepage = "gb2312") : base(PrinterName, codepage) {
      _ZHCNMode = new ZHCNMode();
    }

    private readonly IEnableZHCNMode _ZHCNMode;
    public void EnableZHCNMode() {
      Append(_ZHCNMode.EnableZHCNMode());
    }
    public void DisableZHCNMode() {
      Append(_ZHCNMode.DisableZHCNMode());
    }

  }
}
