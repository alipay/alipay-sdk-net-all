using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducatePlaceDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducatePlaceDetailQueryModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 位置外部唯一编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 位置ID
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }
    }
}
