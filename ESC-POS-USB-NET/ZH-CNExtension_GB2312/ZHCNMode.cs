namespace ESC_POS_USB_NET.ZH_CNExtension_GB2312 {
  using System;
  using System.Collections.Generic;
  using System.Text;

  using ESC_POS_USB_NET.Interfaces.Command;

  class ZHCNMode : IEnableZHCNMode {
    public byte[] EnableZHCNMode() => new byte[] { 0x1C, 0x26, };

    public byte[] DisableZHCNMode() => new byte[] { 0x1C, 0x2E };
  }
}
