using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerModifyModel : AopObject
    {
        /// <summary>
        /// 修改客户请求
        /// </summary>
        [XmlElement("update_customer_request")]
        public UpdateCustomerRequest UpdateCustomerRequest { get; set; }
    }
}
