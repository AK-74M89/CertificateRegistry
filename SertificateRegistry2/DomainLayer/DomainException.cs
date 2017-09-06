using System;

namespace SertificateRegistry2.DomainLayer
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