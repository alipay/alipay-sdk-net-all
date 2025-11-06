using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaSignqrurlCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthcaSignqrurlCreateResponse : AopResponse
    {
        /// <summary>
        /// 签署合同ID
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }

        /// <summary>
        /// 签约链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
