using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceriskGetResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceriskGetResponse : AopResponse
    {
        /// <summary>
        /// 风险内容
        /// </summary>
        [XmlElement("risk_content")]
        public string RiskContent { get; set; }
    }
}
