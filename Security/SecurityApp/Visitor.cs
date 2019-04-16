using System;

namespace SecurityApp
{
    public class Visitor : Entity
    {
        public string Name { get; set; }
        public DateTime WhenArrived { get; set; }
        public DateTime WhenLeaved { get; set; }
        public long CertificateNumber { get; set; }
    }
}
