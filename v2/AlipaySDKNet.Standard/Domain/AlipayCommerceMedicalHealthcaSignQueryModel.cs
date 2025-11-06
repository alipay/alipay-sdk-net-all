using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthcaSignQueryModel : AopObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 签署合同ID
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }
    }
}
