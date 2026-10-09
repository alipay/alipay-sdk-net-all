using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GreenPaginator Data Structure.
    /// </summary>
    [Serializable]
    public class GreenPaginator : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
