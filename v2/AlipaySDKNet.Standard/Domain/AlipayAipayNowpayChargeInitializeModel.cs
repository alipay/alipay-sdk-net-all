using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpayChargeInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpayChargeInitializeModel : AopObject
    {
        /// <summary>
        /// 配置完成返回平台地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 商品所有者标识
        /// </summary>
        [XmlElement("external_owner_id")]
        public string ExternalOwnerId { get; set; }

        /// <summary>
        /// 商品/应用标识
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pricing_mode_list")]
        [XmlArrayItem("pricing_mode")]
        public List<PricingMode> PricingModeList { get; set; }

        /// <summary>
        /// 商品图标链接地址
        /// </summary>
        [XmlElement("product_icon_url")]
        public string ProductIconUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 商品详情页
        /// </summary>
        [XmlElement("product_url")]
        public string ProductUrl { get; set; }
    }
}
