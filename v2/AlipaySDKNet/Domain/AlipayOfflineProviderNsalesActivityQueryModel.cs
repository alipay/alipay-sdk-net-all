using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesActivityQueryModel : AopObject
    {
        /// <summary>
        /// 卖进订单活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
