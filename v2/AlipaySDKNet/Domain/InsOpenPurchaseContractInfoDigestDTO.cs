using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenPurchaseContractInfoDigestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenPurchaseContractInfoDigestDTO : AopObject
    {
        /// <summary>
        /// 合约ID
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
