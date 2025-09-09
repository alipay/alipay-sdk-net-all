using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderlistQueryModel : AopObject
    {
        /// <summary>
        /// 格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_create_end")]
        public string GmtCreateEnd { get; set; }

        /// <summary>
        /// 起始创建时间 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("gmt_create_start")]
        public string GmtCreateStart { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlArray("order_status_list")]
        [XmlArrayItem("string")]
        public List<string> OrderStatusList { get; set; }

        /// <summary>
        /// 页数，大于等于1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页订单数，最大100
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 1:desc, 2:asc
        /// </summary>
        [XmlElement("sort_order")]
        public string SortOrder { get; set; }
    }
}
