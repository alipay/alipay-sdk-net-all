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
        /// 在支付宝开放平台中，服务商的pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 支付宝小程序的app id。商家的扫码点餐物料对应的小程序的app id。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 二维码码值。桌码、台码、电子屏等展示的扫码点餐二维码的码值。
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 政策返佣的pid。填写isv在支付宝开放平台的pid。
        /// </summary>
        [XmlElement("rebate_pid")]
        public string RebatePid { get; set; }

        /// <summary>
        /// 商家收单的pid（直连商户id）
        /// </summary>
        [XmlElement("seller_checkout_pid")]
        public string SellerCheckoutPid { get; set; }

        /// <summary>
        /// 商家收单的smid（间联商户id）
        /// </summary>
        [XmlElement("seller_checkout_smid")]
        public string SellerCheckoutSmid { get; set; }

        /// <summary>
        /// 商家的支付宝门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
