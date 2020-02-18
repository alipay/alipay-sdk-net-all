using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageCreative Data Structure.
    /// </summary>
    [Serializable]
    public class PageCreative : AopObject
    {
        /// <summary>
        /// 创意详情列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("creative_detail")]
        public List<CreativeDetail> List { get; set; }

        /// <summary>
        /// 创意分页信息
        /// </summary>
        [XmlElement("pagination")]
        public PageInfo Pagination { get; set; }
    }
}
