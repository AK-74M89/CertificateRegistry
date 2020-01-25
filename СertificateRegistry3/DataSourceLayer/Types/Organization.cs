namespace CertificateRegistry3.DataSourceLayer
{
    public class Organization
    {
        private int id_organization;
        private string name;

        public Organization(int ID_Organization, string Name)
        {
            id_organization = ID_Organization;
            name = Name;
        }

        public int ID_Organization
        {
            get { return id_organization; }
            set { id_organization = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
