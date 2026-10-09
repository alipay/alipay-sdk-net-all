using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletPayurlApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletPayurlApplyModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付参数, 当前仅支持WalletPriority（红包 > 钱包 > 主支付工具）
        /// </summary>
        [XmlElement("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
