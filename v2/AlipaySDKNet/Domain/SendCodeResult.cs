using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SendCodeResult Data Structure.
    /// </summary>
    [Serializable]
    public class SendCodeResult : AopObject
    {
        /// <summary>
        /// 服务商发奖后返回的券码列表
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 发奖后返回的与券码对应的券码使用链接，在支付宝卡包-券详情以二维码方式展示 当前字段已废弃(后续可使用qr_code)
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 支付宝的商品信息
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户领券之后在服务商(商户)侧提供的券详情展示页面。在支付宝卡包中展示链接，用户点击可以跳转到服务商券详情页 当前字段已废弃(无效参数本地商品未应用)
        /// </summary>
        [XmlElement("merchant_order_url")]
        public string MerchantOrderUrl { get; set; }

        /// <summary>
        /// 商家侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧sku ID
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 三方码二维码值，可填入URL或字符串。长度不能超过512。
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 支付宝平台侧sku ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
