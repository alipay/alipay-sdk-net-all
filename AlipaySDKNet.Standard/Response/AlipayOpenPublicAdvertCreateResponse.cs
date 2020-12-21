using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertCreateResponse : AopResponse
    {
        /// <summary>
        /// 广告分组标识
        /// </summary>
        [XmlElement("advert_group")]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }
    }
}
