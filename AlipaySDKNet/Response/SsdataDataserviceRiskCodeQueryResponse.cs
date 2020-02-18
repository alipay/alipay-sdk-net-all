using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceRiskCodeQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskCodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否命中yes/no
        /// </summary>
        [XmlElement("hit")]
        public string Hit { get; set; }

        /// <summary>
        /// 风险码,具体见接口文档
        /// </summary>
        [XmlArray("risk_code")]
        [XmlArrayItem("string")]
        public List<string> RiskCode { get; set; }

        /// <summary>
        /// 调用订单号
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 验证码, 具体见接口文档
        /// </summary>
        [XmlArray("verify_code")]
        [XmlArrayItem("string")]
        public List<string> VerifyCode { get; set; }
    }
}
