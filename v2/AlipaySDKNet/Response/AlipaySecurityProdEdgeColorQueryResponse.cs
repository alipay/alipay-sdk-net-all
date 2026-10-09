using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdEdgeColorQueryResponse.
    /// </summary>
    public class AlipaySecurityProdEdgeColorQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务端解析后的风险等级信息
        /// </summary>
        [XmlElement("risk_result")]
        public string RiskResult { get; set; }
    }
}
