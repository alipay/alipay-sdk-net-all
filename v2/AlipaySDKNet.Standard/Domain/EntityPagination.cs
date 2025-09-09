using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EntityPagination Data Structure.
    /// </summary>
    [Serializable]
    public class EntityPagination : AopObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量，表示可返回的实体总数是多少个
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
