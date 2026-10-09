using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappLayerdetailQueryModel : AopObject
    {
        /// <summary>
        /// 有礼活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
