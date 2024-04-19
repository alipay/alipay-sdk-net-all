using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlawSmartcontractcodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlawSmartcontractcodeModifyModel : AopObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 鉴权token
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
