using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAdvertDeleteModel : AopObject
    {
        /// <summary>
        /// 待删除的广告位分组标识
        /// </summary>
        [XmlElement("advert_group")]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 待删除的广告位id
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }
    }
}
