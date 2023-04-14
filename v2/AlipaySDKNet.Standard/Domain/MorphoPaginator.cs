using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MorphoPaginator Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoPaginator : AopObject
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("page_count")]
        public long PageCount { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
