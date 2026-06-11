using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntLinkeQueryreimbursequotaQueryResponse.
    /// </summary>
    public class AntLinkeQueryreimbursequotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 额度
        /// </summary>
        [XmlElement("quota_usd")]
        public string QuotaUsd { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("subscription_list")]
        [XmlArrayItem("string")]
        public List<string> SubscriptionList { get; set; }

        /// <summary>
        /// 年月
        /// </summary>
        [XmlElement("year_month")]
        public string YearMonth { get; set; }
    }
}
