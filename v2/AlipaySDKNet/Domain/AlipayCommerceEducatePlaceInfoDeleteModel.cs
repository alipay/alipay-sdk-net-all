using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducatePlaceInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducatePlaceInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 位置ID
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }
    }
}
