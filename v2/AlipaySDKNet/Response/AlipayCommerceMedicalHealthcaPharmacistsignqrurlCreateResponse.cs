using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPharmacistsignqrurlCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthcaPharmacistsignqrurlCreateResponse : AopResponse
    {
        /// <summary>
        /// 二维码链接
        /// </summary>
        [XmlElement("qr_url")]
        public string QrUrl { get; set; }

        /// <summary>
        /// 签署合同ID
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }
    }
}
