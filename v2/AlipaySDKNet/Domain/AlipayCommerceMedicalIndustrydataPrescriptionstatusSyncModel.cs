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
        /// 购药单状态
        /// </summary>
        [XmlElement("drug_purchase_status")]
        public string DrugPurchaseStatus { get; set; }

        /// <summary>
        /// 处方过期时间，为空则阿福互医兜底7*24小时过期处理
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public PlatformPrescriptionStatusExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 院内购药订单详情页
        /// </summary>
        [XmlElement("medical_buy_order_detail_url")]
        public string MedicalBuyOrderDetailUrl { get; set; }

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
        /// 处方笺图片
        /// </summary>
        [XmlElement("prescription_image_url")]
        public string PrescriptionImageUrl { get; set; }

        /// <summary>
        /// 处方笺pdf
        /// </summary>
        [XmlElement("prescription_pdf_url")]
        public string PrescriptionPdfUrl { get; set; }

        /// <summary>
        /// 处方状态： 审核中:AUDIT 已过期:EXPIRED 审核不通过:AUDIT_FAIL 已退回:RETURNED 审核通过:AUDIT_PASS 已使用:USED 已撤销:REVOKED
        /// </summary>
        [XmlElement("prescription_status")]
        public string PrescriptionStatus { get; set; }
    }
}
