using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPoiCreateResponse.
    /// </summary>
    public class AlipayOpenMiniPoiCreateResponse : AopResponse
    {
        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }
    }
}
