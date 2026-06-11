using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionReimbursementVO Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionReimbursementVO : AopObject
    {
        /// <summary>
        /// 报销原因说明
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 订阅的产品
        /// </summary>
        [XmlElement("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// 是否可报销
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }

        /// <summary>
        /// 年月
        /// </summary>
        [XmlElement("year_month")]
        public string YearMonth { get; set; }
    }
}
