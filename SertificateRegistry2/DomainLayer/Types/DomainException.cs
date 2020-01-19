using System;

namespace CertificateRegistry3.DomainLayer
{
    [Serializable]
    class DomainException: Exception
    {
        public DomainException(string Message)
            : base(Message)
        {
        }
    }
}