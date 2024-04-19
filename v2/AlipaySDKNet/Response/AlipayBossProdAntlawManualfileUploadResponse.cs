using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlawManualfileUploadResponse.
    /// </summary>
    public class AlipayBossProdAntlawManualfileUploadResponse : AopResponse
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 智能撰写生成的合同ID,用于查询合同详情
        /// </summary>
        [XmlElement("smart_contract_id")]
        public string SmartContractId { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }
    }
}
