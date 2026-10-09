using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskAppinfoDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskAppinfoDetectResponse : AopResponse
    {
        /// <summary>
        /// app风险列表信息
        /// </summary>
        [XmlElement("app_risk_info_list")]
        public string AppRiskInfoList { get; set; }

        /// <summary>
        /// 产商请求返回为false，主动推送为true
        /// </summary>
        [XmlElement("push")]
        public bool Push { get; set; }

        /// <summary>
        /// 对应请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
