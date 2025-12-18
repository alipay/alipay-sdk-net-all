using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerQueryModel : AopObject
    {
        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 客户常用名
        /// </summary>
        [XmlElement("customer_short_name")]
        public string CustomerShortName { get; set; }
    }
}
