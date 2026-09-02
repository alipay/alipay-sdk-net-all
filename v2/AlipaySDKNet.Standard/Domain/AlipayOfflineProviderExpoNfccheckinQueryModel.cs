using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoNfccheckinQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoNfccheckinQueryModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("user_mark")]
        public string UserMark { get; set; }
    }
}
