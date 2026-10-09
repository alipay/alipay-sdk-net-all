using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargingOption Data Structure.
    /// </summary>
    [Serializable]
    public class ChargingOption : AopObject
    {
        /// <summary>
        /// 档位类型
        /// </summary>
        [XmlElement("billing_mode")]
        public string BillingMode { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 档位名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 时长包周期类型
        /// </summary>
        [XmlElement("duration_period")]
        public string DurationPeriod { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("entitlement_rule")]
        public string EntitlementRule { get; set; }

        /// <summary>
        /// 价格计划标识
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 展示价格，十进制，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 价格快照版本
        /// </summary>
        [XmlElement("price_version")]
        public long PriceVersion { get; set; }

        /// <summary>
        /// 次数或积分数量，单位个
        /// </summary>
        [XmlElement("quota_amount")]
        public long QuotaAmount { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("quota_unit")]
        public string QuotaUnit { get; set; }

        /// <summary>
        /// 档位标识，平台原样回传
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
