using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContentInfo : AopObject
    {
        /// <summary>
        /// 详情明细
        /// </summary>
        [XmlArray("content_details")]
        [XmlArrayItem("content_detail")]
        public List<ContentDetail> ContentDetails { get; set; }
    }
}
