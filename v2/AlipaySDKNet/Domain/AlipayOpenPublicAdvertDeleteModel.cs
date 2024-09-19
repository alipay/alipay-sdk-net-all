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
        /// 待删除的广告位分组标识，删除个性化广告位需传递此参数。
        /// </summary>
        [XmlElement("advert_group")]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 待删除的广告位id，删除通投广告位需传递此参数
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }
    }
}
