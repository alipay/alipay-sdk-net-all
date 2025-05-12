using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducatePlaceInfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducatePlaceInfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 父级楼栋ID。
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 位置标签
        /// </summary>
        [XmlElement("place_label")]
        public string PlaceLabel { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }
    }
}
