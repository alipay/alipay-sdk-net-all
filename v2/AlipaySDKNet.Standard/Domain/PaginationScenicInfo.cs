using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaginationScenicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaginationScenicInfo : AopObject
    {
        /// <summary>
        /// 页码，表示当前页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 景区信息
        /// </summary>
        [XmlArray("scenic_info")]
        [XmlArrayItem("scenic_info")]
        public List<ScenicInfo> ScenicInfo { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
