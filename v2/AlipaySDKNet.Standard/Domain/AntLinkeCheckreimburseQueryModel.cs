using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntLinkeCheckreimburseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntLinkeCheckreimburseQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("subscription_month_pair_list")]
        [XmlArrayItem("subscription_month_pair")]
        public List<SubscriptionMonthPair> SubscriptionMonthPairList { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
