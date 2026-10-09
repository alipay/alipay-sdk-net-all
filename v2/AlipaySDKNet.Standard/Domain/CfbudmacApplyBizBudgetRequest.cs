using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CfbudmacApplyBizBudgetRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CfbudmacApplyBizBudgetRequest : AopObject
    {
        /// <summary>
        /// 申请金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 假如，amount字段为100 APPEND: 增加，在原有基础上增加100 APPEND_TO:增加到，将原有基础增加到100
        /// </summary>
        [XmlElement("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// bba编码
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 业务申请的时间，默认不填写为当前时间，填写后可以按照业务申请时间来进行预算申请有效期校验
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务活动唯一id,用于幂等,与biz_type一起组成幂等索引，不可重复
        /// </summary>
        [XmlElement("biz_uk_id")]
        public string BizUkId { get; set; }

        /// <summary>
        /// 币种编码，如果不填写，默认为156人民币
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [XmlElement("time_zone")]
        public string TimeZone { get; set; }
    }
}
