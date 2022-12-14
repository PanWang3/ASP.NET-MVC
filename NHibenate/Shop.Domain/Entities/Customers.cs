namespace Shop.Domain.Entities
{
    public class Customers
    {
        //字段要为virtual，否则出现 NHiberante.InvalidProxyTypeException
        /// <summary>
        /// CustomerID
        /// </summary>
        public virtual string CustomerID { get; set; }
        /// <summary>
        /// CompanyName
        /// </summary>
        public virtual string CompanyName { get; set; }
        /// <summary>
        /// ContactName
        /// </summary>
        public virtual string ContactName { get; set; }
        /// <summary>
        /// ContactTitle
        /// </summary>
        public virtual string ContactTitle { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public virtual string City { get; set; }
        /// <summary>
        /// Region
        /// </summary>
        public virtual string Region { get; set; }
        /// <summary>
        /// PostCode
        /// </summary>
        public virtual string PostCode { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public virtual string Country { get; set; }
        /// <summary>
        /// Phone
        /// </summary>
        public virtual string Phone { get; set; }
        /// <summary>
        /// Fax
        /// </summary>
        public virtual string Fax { get; set; }
    }
}