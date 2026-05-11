using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcustomerCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfcustomerCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建客户结果
        /// </summary>
        [XmlElement("result")]
        public SaleForceCreateCustomerResponse Result { get; set; }
    }
}
