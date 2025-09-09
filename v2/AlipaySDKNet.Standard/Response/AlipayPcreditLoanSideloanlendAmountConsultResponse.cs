using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendAmountConsultResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanlendAmountConsultResponse : AopResponse
    {
        /// <summary>
        /// 渠道户状态枚举值（INIT/ENABLE/DISABLE）
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 授信总额度，单位元，保留?数点后两位
        /// </summary>
        [XmlElement("credit_quota")]
        public string CreditQuota { get; set; }

        /// <summary>
        /// 日利率，6位小数
        /// </summary>
        [XmlElement("daily_interest_rate")]
        public string DailyInterestRate { get; set; }

        /// <summary>
        /// 授信失效时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 年利率，6位?数，日利率*360
        /// </summary>
        [XmlElement("interest_rate")]
        public string InterestRate { get; set; }

        /// <summary>
        /// SUCCESS - 成功、NEED_RETRY - 需要重试、FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 支用不准入
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 授信额度查询失败时对应二级错误码的错误描述
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }

        /// <summary>
        /// 额度?效?期
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 授信生效状态，VALID 正常、FROZEN 冻结、INVALID 失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 剩余可?授信额度，单位元，保留小数点后两位，包含临时额度
        /// </summary>
        [XmlElement("surplus_quota")]
        public string SurplusQuota { get; set; }

        /// <summary>
        /// 临时授信额度，单位元，保留2位小数
        /// </summary>
        [XmlElement("temp_credit_quota")]
        public string TempCreditQuota { get; set; }

        /// <summary>
        /// 2023-02-01 18:00:00 临时授信额度失效?期，当临时 额度存在时，必填。2023-01-01 23:59:59 代表到有 效期到【2023-01-01 23:59:59】，过了这?秒，下? 秒就不可?了
        /// </summary>
        [XmlElement("temp_credit_quota_end_time")]
        public string TempCreditQuotaEndTime { get; set; }

        /// <summary>
        /// 临时授信额度?效?期，当临时额度存在时，必填
        /// </summary>
        [XmlElement("temp_credit_quota_start_time")]
        public string TempCreditQuotaStartTime { get; set; }

        /// <summary>
        /// 限时降价临时日利率，保留小数点后6位
        /// </summary>
        [XmlElement("temp_daily_interest_rate")]
        public string TempDailyInterestRate { get; set; }

        /// <summary>
        /// 限时降价临时年利率，6位小数
        /// </summary>
        [XmlElement("temp_interest_rate")]
        public string TempInterestRate { get; set; }

        /// <summary>
        /// 限时降价临时利率失效时间，当临时年利率存在时，必填 精确到秒，需要给到精确到秒的结果。2023-01-01 23:59:59 代表到有效期到【2023-01-01 23:59:59】，过了这?秒，下?秒就不可?了
        /// </summary>
        [XmlElement("temp_interest_rate_end_time")]
        public string TempInterestRateEndTime { get; set; }

        /// <summary>
        /// 限时降价临时利率?效时间，当临时年利率存在时，必填
        /// </summary>
        [XmlElement("temp_interest_rate_start_time")]
        public string TempInterestRateStartTime { get; set; }
    }
}
