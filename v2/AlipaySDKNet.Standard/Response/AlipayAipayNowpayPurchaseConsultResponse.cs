using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpayPurchaseConsultResponse.
    /// </summary>
    public class AlipayAipayNowpayPurchaseConsultResponse : AopResponse
    {
        /// <summary>
        /// 收费能力状态
        /// </summary>
        [XmlElement("capability_status")]
        public string CapabilityStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("charging_options")]
        [XmlArrayItem("consult_charging_option")]
        public List<ConsultChargingOption> ChargingOptions { get; set; }

        /// <summary>
        /// 决策结果
        /// </summary>
        [XmlElement("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 商品图标
        /// </summary>
        [XmlElement("product_icon_url")]
        public string ProductIconUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 购买二维码
        /// </summary>
        [XmlElement("purchase_qr_code")]
        public string PurchaseQrCode { get; set; }

        /// <summary>
        /// 购买链接
        /// </summary>
        [XmlElement("purchase_url")]
        public string PurchaseUrl { get; set; }

        /// <summary>
        /// DENY 时原因
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 表示本次有效权益的生效时间
        /// </summary>
        [XmlElement("valid_from")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// 表示本次有效权益的结束时间
        /// </summary>
        [XmlElement("valid_until")]
        public string ValidUntil { get; set; }
    }
}
