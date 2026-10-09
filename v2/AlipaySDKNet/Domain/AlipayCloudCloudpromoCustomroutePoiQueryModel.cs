using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoCustomroutePoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoCustomroutePoiQueryModel : AopObject
    {
        /// <summary>
        /// 伴游卡片唯一id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
