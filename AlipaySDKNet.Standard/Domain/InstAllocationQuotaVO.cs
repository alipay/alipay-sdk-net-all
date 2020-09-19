using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstAllocationQuotaVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstAllocationQuotaVO : AopObject
    {
        /// <summary>
        /// 管控账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// BANK_CARD/BALANCE_ACCOUNT，银行卡/余额户
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 额度限制是否激活
        /// </summary>
        [XmlElement("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 额度配置附言
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// OUT/IN，流出限额/流入限额
        /// </summary>
        [XmlElement("quota_mode")]
        public string QuotaMode { get; set; }

        /// <summary>
        /// 额度金额，默认人民币币种
        /// </summary>
        [XmlElement("quota_value")]
        public string QuotaValue { get; set; }
    }
}
