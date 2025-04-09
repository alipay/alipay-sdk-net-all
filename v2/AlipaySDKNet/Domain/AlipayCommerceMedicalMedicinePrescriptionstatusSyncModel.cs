using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicinePrescriptionstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicinePrescriptionstatusSyncModel : AopObject
    {
        /// <summary>
        /// 审核药师手写签名url
        /// </summary>
        [XmlElement("checker_hand_signature_url")]
        public string CheckerHandSignatureUrl { get; set; }

        /// <summary>
        /// 审核药师名称
        /// </summary>
        [XmlElement("checker_name")]
        public string CheckerName { get; set; }

        /// <summary>
        /// 外部的处方号
        /// </summary>
        [XmlElement("ext_prescription_code")]
        public string ExtPrescriptionCode { get; set; }

        /// <summary>
        /// 支付宝问诊订单编号
        /// </summary>
        [XmlElement("inquiry_id")]
        public string InquiryId { get; set; }

        /// <summary>
        /// 支付宝为每个对接方分配的平台号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 处方状态
        /// </summary>
        [XmlElement("prescription_status")]
        public string PrescriptionStatus { get; set; }

        /// <summary>
        /// 状态变更原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
