using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletDepositruleApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletDepositruleApplyModel : AopObject
    {
        /// <summary>
        /// 钱包场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 充值后通知地址
        /// </summary>
        [XmlElement("deposit_notify_url")]
        public string DepositNotifyUrl { get; set; }

        /// <summary>
        /// 充值规则业务扩展参数
        /// </summary>
        [XmlElement("deposit_rule_biz_param")]
        public DepositRuleBizParam DepositRuleBizParam { get; set; }

        /// <summary>
        /// 充值规则类型
        /// </summary>
        [XmlElement("deposit_rule_type")]
        public string DepositRuleType { get; set; }

        /// <summary>
        /// 外部请求业务单号，保持幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 充值规则申请主体
        /// </summary>
        [XmlElement("principal_info")]
        public ParticipantForm PrincipalInfo { get; set; }

        /// <summary>
        /// 场景钱包
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
