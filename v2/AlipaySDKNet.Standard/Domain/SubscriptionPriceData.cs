using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionPriceData Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionPriceData : AopObject
    {
        /// <summary>
        /// 价格元数据，必须是合法的 JSON object 字符串，且每个 value 必须是字符串
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 完整商品信息，引用 SubscriptionProductData 复杂类型
        /// </summary>
        [XmlElement("product_data")]
        public SubscriptionProductData ProductData { get; set; }

        /// <summary>
        /// 周期价格配置；Submode 仅支持周期订阅价格，引用 SubscriptionRecurring 复杂类型
        /// </summary>
        [XmlElement("recurring")]
        public SubscriptionRecurring Recurring { get; set; }

        /// <summary>
        /// 商品单价，单位为分，必须大于 0；后端转换为以元表示的价格快照
        /// </summary>
        [XmlElement("unit_amount")]
        public long UnitAmount { get; set; }
    }
}
