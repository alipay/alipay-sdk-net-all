using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducatePlaceChildBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducatePlaceChildBatchqueryModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 位置ID
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }
    }
}
