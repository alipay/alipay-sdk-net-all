using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionMonthPair Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionMonthPair : AopObject
    {
        /// <summary>
        /// 年月声明
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("subscription")]
        public string Subscription { get; set; }
    }
}
