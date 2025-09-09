using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDrugorderstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataDrugorderstatusSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝药品订单id
        /// </summary>
        [XmlElement("alipay_drug_order_id")]
        public string AlipayDrugOrderId { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝问诊单id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 支付宝处方订单id
        /// </summary>
        [XmlElement("alipay_prescription_id")]
        public string AlipayPrescriptionId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("drug_order_status")]
        public string DrugOrderStatus { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public PlatformDrugOrderStatusExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 平台用户id
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部药品订单id
        /// </summary>
        [XmlElement("out_drug_order_id")]
        public string OutDrugOrderId { get; set; }

        /// <summary>
        /// 外部问诊单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部处方订单id
        /// </summary>
        [XmlElement("out_prescription_id")]
        public string OutPrescriptionId { get; set; }

        /// <summary>
        /// 外部平台编号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
