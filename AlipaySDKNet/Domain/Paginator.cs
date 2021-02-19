using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Paginator Data Structure.
    /// </summary>
    [Serializable]
    public class Paginator : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数, 最大值只能是10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数, 作为参数时该值不需要填写, 填写将被忽略
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }
    }
}
