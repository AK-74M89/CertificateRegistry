using System;

namespace SertificateRegistry2
{
    public class CertificatesListItem
    {
        private int id_certificate;
        private string name;
        private string number;
        private DateTime begin;
        private DateTime end;
        private string organization;

        public CertificatesListItem(int ID_Certificate, string Name, string Number, DateTime Begin, DateTime End, string Organization)
        {
            id_certificate = ID_Certificate;
            name = Name;
            number = Number;
            begin = Begin;
            end = End;
            organization = Organization;
        }

        public int ID_Certificate
        {
            get { return id_certificate; }
            set { id_certificate = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public DateTime Begin
        {
            get { return begin; }
            set { begin = value; }
        }
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
        public string Organization
        {
            get { return organization; }
            set { organization = value; }
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