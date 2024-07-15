using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletWithdrawModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletWithdrawModel : AopObject
    {
        /// <summary>
        /// 提现金额，单位：元（人民币）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 定制化的提现策略
        /// </summary>
        [XmlElement("extend_strategy")]
        public ExtendStrategy ExtendStrategy { get; set; }

        /// <summary>
        /// 提现标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 钱包营销规则
        /// </summary>
        [XmlElement("wallet_marketing_rule")]
        public WalletMarketingRule WalletMarketingRule { get; set; }

        /// <summary>
        /// 提现扩展参数
        /// </summary>
        [XmlElement("withdraw_extend")]
        public WithdrawExtend WithdrawExtend { get; set; }
    }
}
