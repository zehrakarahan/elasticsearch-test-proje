using System;
using System.Collections.Generic;
using System.Text;

namespace Elastictest.EntityFramework
{
    public class Loglama
    {
        public Loglama()
        {
            GuidNo = Guid.NewGuid();
        }
        public Guid GuidNo { get; set; }
        public string LogDurumu { get; set; }

        public string LogAciklama { get; set; }

        public string PcAdi { get; set; }

        public string PcİpAdresi { get; set; }
    }
}
