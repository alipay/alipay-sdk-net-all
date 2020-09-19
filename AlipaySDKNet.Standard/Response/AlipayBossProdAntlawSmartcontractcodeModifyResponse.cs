using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlawSmartcontractcodeModifyResponse.
    /// </summary>
    public class AlipayBossProdAntlawSmartcontractcodeModifyResponse : AopResponse
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }
    }
}
