using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaginationCommGroup Data Structure.
    /// </summary>
    [Serializable]
    public class PaginationCommGroup : AopObject
    {
        /// <summary>
        /// 出参列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("kbdish_comm_group_info")]
        public List<KbdishCommGroupInfo> List { get; set; }

        /// <summary>
        /// 页码，表示当前页数
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
