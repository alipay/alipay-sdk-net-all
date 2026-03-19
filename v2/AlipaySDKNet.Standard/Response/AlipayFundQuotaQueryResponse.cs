using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundQuotaQueryResponse.
    /// </summary>
    public class AlipayFundQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 当active_new_quota_daily_remain_limited返回true时会有值，代表收到了限制，如果是安全限制需申请解限会返回SECURITY_PUNISHED，如果账户额度限制需先提升账户额度会返回ACCOUNT_QUOTA_LIMITED
        /// </summary>
        [XmlElement("active_new_quota_daily_remain_limit_type")]
        public string ActiveNewQuotaDailyRemainLimitType { get; set; }

        /// <summary>
        /// 标识单日剩余额度是否被其他规则限制，如果是，需要先解除限制；当active_quota_is_new=true时，返回该字段
        /// </summary>
        [XmlElement("active_new_quota_daily_remain_limited")]
        public bool ActiveNewQuotaDailyRemainLimited { get; set; }

        /// <summary>
        /// 当active_new_quota_monthly_remain_limited返回true时会有值，代表收到了限制，如果是安全限制需申请解限会返回SECURITY_PUNISHED，如果账户额度限制需先提升账户额度会返回ACCOUNT_QUOTA_LIMITED
        /// </summary>
        [XmlElement("active_new_quota_monthly_remain_limit_type")]
        public string ActiveNewQuotaMonthlyRemainLimitType { get; set; }

        /// <summary>
        /// 标识单月剩余额度是否被其他规则限制，如果是，需要先解除限制；当active_quota_is_new=true时，返回该字段
        /// </summary>
        [XmlElement("active_new_quota_monthly_remain_limited")]
        public bool ActiveNewQuotaMonthlyRemainLimited { get; set; }

        /// <summary>
        /// 当返回true时，表明查询返回的额度值以new_quota_开头字段返回值生效；否则，额度值以to_开头字段返回值生效
        /// </summary>
        [XmlElement("active_quota_is_new")]
        public bool ActiveQuotaIsNew { get; set; }

        /// <summary>
        /// 单日最高转账限额，单位为元，精确到小数点后两位；当active_quota_is_new=true时，返回该字段
        /// </summary>
        [XmlElement("new_quota_daily")]
        public string NewQuotaDaily { get; set; }

        /// <summary>
        /// 单日剩余额度，单位为元，精确到小数点后两位；当active_quota_is_new=true时，返回该字段
        /// </summary>
        [XmlElement("new_quota_daily_remain")]
        public string NewQuotaDailyRemain { get; set; }

        /// <summary>
        /// 单月最高转账限额，单位为元，精确到小数点后两位；当active_quota_is_new=true时，返回该字段
        /// </summary>
        [XmlElement("new_quota_monthly")]
        public string NewQuotaMonthly { get; set; }

        /// <summary>
        /// 单月剩余额度 ，单位为元，精确到小数点后两位；当active_quota_is_new=true时，返回该字段
        /// </summary>
        [XmlElement("new_quota_monthly_remain")]
        public string NewQuotaMonthlyRemain { get; set; }

        /// <summary>
        /// 单笔最大金额，单位为元，精确到小数点后两位；当active_quota_is_new=true时，返回该字段
        /// </summary>
        [XmlElement("new_quota_single_max")]
        public string NewQuotaSingleMax { get; set; }

        /// <summary>
        /// 单笔最小金额，单位为元，精确到小数点后两位；当active_quota_is_new=true且设置了最小额度时，返回该字段；
        /// </summary>
        [XmlElement("new_quota_single_min")]
        public string NewQuotaSingleMin { get; set; }

        /// <summary>
        /// 对公日可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_corporate_daily_available_amount")]
        public string ToCorporateDailyAvailableAmount { get; set; }

        /// <summary>
        /// 对公月可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_corporate_monthly_available_amount")]
        public string ToCorporateMonthlyAvailableAmount { get; set; }

        /// <summary>
        /// 对私日可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_private_daily_available_amount")]
        public string ToPrivateDailyAvailableAmount { get; set; }

        /// <summary>
        /// 对私月可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_private_monthly_available_amount")]
        public string ToPrivateMonthlyAvailableAmount { get; set; }
    }
}
