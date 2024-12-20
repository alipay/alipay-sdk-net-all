using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataPrescriptionstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataPrescriptionstatusSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝处方id
        /// </summary>
        [XmlElement("alipay_prescription_id")]
        public string AlipayPrescriptionId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public PlatformPrescriptionStatusExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 外部平台用户id
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部处方id
        /// </summary>
        [XmlElement("out_prescription_id")]
        public string OutPrescriptionId { get; set; }

        /// <summary>
        /// 外部平台编号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 处方状态： 审核中:AUDIT 已过期:EXPIRED 审核不通过:AUDIT_FAIL 已退回:RETURNED 审核通过:AUDIT_PASS
        /// </summary>
        [XmlElement("prescription_status")]
        public string PrescriptionStatus { get; set; }
    }
}
