using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTY_DTO
    {
        private int _IDCTY;
        private string _TenCTY;
        private string _EmailCTY;
        private string _sdtCty;
        private string _DchiCty;

        public int IDCTY { get => _IDCTY; set => _IDCTY = value; }
        public string TenCTY { get => _TenCTY; set => _TenCTY = value; }
        public string EmailCTY { get => _EmailCTY; set => _EmailCTY = value; }
        public string SdtCty { get => _sdtCty; set => _sdtCty = value; }
        public string DchiCty { get => _DchiCty; set => _DchiCty = value; }
    }
}
