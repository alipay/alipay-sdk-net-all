using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentErrorDetai Data Structure.
    /// </summary>
    [Serializable]
    public class ContentErrorDetai : AopObject
    {
        /// <summary>
        /// 品检后具体错误项，包含错误字段，原本正确值，以及错误值
        /// </summary>
        [XmlArray("error_contents")]
        [XmlArrayItem("content_error_line")]
        public List<ContentErrorLine> ErrorContents { get; set; }

        /// <summary>
        /// 实体物料唯一ID标识，它代表唯一一个实体物料
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
