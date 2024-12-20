using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpromoactivityQueryModel : AopObject
    {
        /// <summary>
        /// 用户活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
