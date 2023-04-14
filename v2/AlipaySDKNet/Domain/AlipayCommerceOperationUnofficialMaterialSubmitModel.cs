using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationUnofficialMaterialSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationUnofficialMaterialSubmitModel : AopObject
    {
        /// <summary>
        /// 服务商身份，选择此字段，此PID为签约物料激励协议的pid（为奖励政策结算PID，请谨慎填写），isv_pid和open_seller_pid，只能一个字段有值。
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 物料档位。枚举值可以是：1,2,3,4。
        /// </summary>
        [XmlElement("material_level")]
        public string MaterialLevel { get; set; }

        /// <summary>
        /// 支付宝小程序的app id。商家的扫码点餐物料对应的小程序的app id。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 自研商家身份，选择此字段，此PID为签约物料激励协议的pid（为奖励政策结算PID，请谨慎填写），isv_pid和open_seller_pid，只能一个字段有值。
        /// </summary>
        [XmlElement("open_seller_pid")]
        public string OpenSellerPid { get; set; }

        /// <summary>
        /// 二维码码值。桌码、台码、电子屏等展示的扫码点餐二维码的码值。
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 商家收单的pid（直连商户id）。seller_checkout_pid和seller_checkout_smid，这两个字段只能一个字段有值。
        /// </summary>
        [XmlElement("seller_checkout_pid")]
        public string SellerCheckoutPid { get; set; }

        /// <summary>
        /// 商家收单的smid（间联商户id）。商家收单的pid和商家收单的smid，这两个字段只能一个字段有值。
        /// </summary>
        [XmlElement("seller_checkout_smid")]
        public string SellerCheckoutSmid { get; set; }

        /// <summary>
        /// 商家的支付宝门店id。如果填写了，则会校验此字段与 商家收单的pid或者商家收单的smid 之间的关系。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
