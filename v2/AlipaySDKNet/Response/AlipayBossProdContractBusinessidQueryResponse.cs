using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdContractBusinessidQueryResponse.
    /// </summary>
    public class AlipayBossProdContractBusinessidQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }
    }
}
