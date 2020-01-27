using System;

namespace CertificateRegistry3.DataSourceLayer
{
    public class Certificate
    {
        private int certificateId;
        private string name;
        private string number;
        private DateTime beginDate;
        private DateTime endDate;
        private string organizationName;

        public Certificate(int CertificateId, string Name, string Number, DateTime BeginDate, DateTime EndDate, string OrganizationName)
        {
            certificateId = CertificateId;
            name = Name;
            number = Number;
            beginDate = BeginDate;
            endDate = EndDate;
            organizationName = OrganizationName;
        }

        public int ID_Certificate
        {
            get { return certificateId; }
            set { certificateId = value; }
        }
        public string CertificateName
        {
            get { return name; }
            set { name = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public DateTime BeginDate
        {
            get { return beginDate; }
            set { beginDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string Organization
        {
            get { return organizationName; }
            set { organizationName = value; }
        }
    }
}
