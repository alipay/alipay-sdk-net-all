using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPrescriptionpdfApproveResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthcaPrescriptionpdfApproveResponse : AopResponse
    {
        /// <summary>
        /// 签署合同ID
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }
    }
}
