using System;

namespace SertificateRegistry2
{
    public struct CertificatesListItem
    {
        public int ID_Certificate;
        public string Name;
        public string Number;
        public DateTime Begin;
        public DateTime End;
        public string Organization;

        public CertificatesListItem(int ID_Certificate, string Name, string Number, DateTime Begin, DateTime End, string Organization)
        {
            this.ID_Certificate = ID_Certificate;
            this.Name = Name;
            this.Number = Number;
            this.Begin = Begin;
            this.End = End;
            this.Organization = Organization;
        }
    }

    public struct OrganizationListItem
    {
        public int ID_Organization;
        public string Name;

        public OrganizationListItem(int ID_Organization, string Name)
        {
            this.ID_Organization = ID_Organization;
            this.Name = Name;
        }
    }
}