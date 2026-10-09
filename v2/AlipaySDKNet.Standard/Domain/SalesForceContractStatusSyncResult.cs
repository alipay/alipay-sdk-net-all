using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalesForceContractStatusSyncResult Data Structure.
    /// </summary>
    [Serializable]
    public class SalesForceContractStatusSyncResult : AopObject
    {
        /// <summary>
        /// 本次接收的合同状态
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 创建甄零合同时传入的甄零合同ID
        /// </summary>
        [XmlElement("external_contract_id")]
        public string ExternalContractId { get; set; }

        /// <summary>
        /// 请求幂等id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
