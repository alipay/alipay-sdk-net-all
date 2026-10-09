using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeOption Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeOption : AopObject
    {
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
        /// 展示价格，十进制，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 额度数量
        /// </summary>
        [XmlElement("quota_amount")]
        public long QuotaAmount { get; set; }

        /// <summary>
        /// 档位标识
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
