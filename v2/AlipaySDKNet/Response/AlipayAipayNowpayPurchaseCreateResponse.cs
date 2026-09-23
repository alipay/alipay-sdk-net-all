using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpayPurchaseCreateResponse.
    /// </summary>
    public class AlipayAipayNowpayPurchaseCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("charging_option")]
        [XmlArrayItem("purchase_charging_option")]
        public List<PurchaseChargingOption> ChargingOption { get; set; }

        /// <summary>
        /// 链接失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 购买二维码
        /// </summary>
        [XmlElement("purchase_qr_code")]
        public string PurchaseQrCode { get; set; }

        /// <summary>
        /// 托管购买页
        /// </summary>
        [XmlElement("purchase_url")]
        public string PurchaseUrl { get; set; }
    }
}
