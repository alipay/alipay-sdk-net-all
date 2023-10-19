using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerCreateModel : AopObject
    {
        /// <summary>
        /// 创建客户请求
        /// </summary>
        [XmlElement("create_customer_request")]
        public CreateCustomerRequest CreateCustomerRequest { get; set; }
    }
}
