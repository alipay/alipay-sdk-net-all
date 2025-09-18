using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWalletAutodepositstatusGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsWalletAutodepositstatusGetModel : AopObject
    {
        /// <summary>
        /// 支付宝钱包产品码
        /// </summary>
        [XmlElement("biz_product_code")]
        public string BizProductCode { get; set; }

        /// <summary>
        /// 支付宝钱包场景码
        /// </summary>
        [XmlElement("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// 支付宝账号ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝账号ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝钱包唯一ID
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 钱包归属主体PID
        /// </summary>
        [XmlElement("wallet_partner_id")]
        public string WalletPartnerId { get; set; }

        /// <summary>
        /// 支付宝钱包模版唯一ID
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
