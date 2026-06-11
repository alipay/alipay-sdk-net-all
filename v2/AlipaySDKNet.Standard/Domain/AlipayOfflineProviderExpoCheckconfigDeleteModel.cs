using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoCheckconfigDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoCheckconfigDeleteModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }
    }
}
