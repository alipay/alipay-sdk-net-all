using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UniOpenResItemDetailInfos Data Structure.
    /// </summary>
    [Serializable]
    public class UniOpenResItemDetailInfos : AopObject
    {
        /// <summary>
        /// 当default_settle_type为alipayWallet时，default_settle_target为钱包id；当default_settle_type为alipayAccount时，default_settle_target为支付宝登录号（脱敏）
        /// </summary>
        [XmlElement("default_settle_target")]
        public string DefaultSettleTarget { get; set; }

        /// <summary>
        /// 默认结算账号类型。 alipayWallet：支付宝钱包 alipayAccount：支付宝登录号
        /// </summary>
        [XmlElement("default_settle_type")]
        public string DefaultSettleType { get; set; }

        /// <summary>
        /// PERSONAL:个人用户（默认值） PERSONAL_MERCHANTS：个人商户
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 个人收款方smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 进件申请单id，与开通时传入的一致
        /// </summary>
        [XmlElement("sub_merchant_order_id")]
        public string SubMerchantOrderId { get; set; }

        /// <summary>
        /// 用户钱包ID，需要商户保存起来
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
