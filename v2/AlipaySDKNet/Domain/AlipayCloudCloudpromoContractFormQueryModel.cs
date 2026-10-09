using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoContractFormQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoContractFormQueryModel : AopObject
    {
        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 三方小程序id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
