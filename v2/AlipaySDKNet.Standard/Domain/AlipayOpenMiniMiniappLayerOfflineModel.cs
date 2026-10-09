using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappLayerOfflineModel : AopObject
    {
        /// <summary>
        /// 快窗有礼活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
