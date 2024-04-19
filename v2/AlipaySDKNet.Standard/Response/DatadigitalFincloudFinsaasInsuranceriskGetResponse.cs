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
        /// 风控信息 不唯一 模型预测、硬规则等场景返回的风险信息
        /// </summary>
        [XmlElement("risk_content")]
        public string RiskContent { get; set; }
    }
}
