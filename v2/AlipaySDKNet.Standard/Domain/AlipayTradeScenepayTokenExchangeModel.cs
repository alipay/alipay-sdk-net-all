using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeScenepayTokenExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeScenepayTokenExchangeModel : AopObject
    {
        /// <summary>
        /// 校园场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 使用的产品对应的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景支付的凭证，有效的场景支付凭证，可以交换出对应的码值
        /// </summary>
        [XmlElement("scene_pay_token")]
        public ScenePayToken ScenePayToken { get; set; }

        /// <summary>
        /// 如果卖方是支付宝的直连商户，传入商户PID
        /// </summary>
        [XmlElement("seller_partner_id")]
        public string SellerPartnerId { get; set; }

        /// <summary>
        /// 如果收款方是支付宝间联商户，需要传该值二级商户ID
        /// </summary>
        [XmlElement("seller_secondary_merchant_id")]
        public string SellerSecondaryMerchantId { get; set; }

        /// <summary>
        /// 子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 场景支付凭证生成的小程序ID，需要和scene_pay_token生成的小程序ID对应
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }
    }
}
