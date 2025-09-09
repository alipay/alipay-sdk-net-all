using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentErrorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContentErrorInfo : AopObject
    {
        /// <summary>
        /// 内容品检错误的数量
        /// </summary>
        [XmlElement("error_amount")]
        public long ErrorAmount { get; set; }

        /// <summary>
        /// 内容品检错误详情
        /// </summary>
        [XmlArray("error_details")]
        [XmlArrayItem("content_error_detai")]
        public List<ContentErrorDetai> ErrorDetails { get; set; }
    }
}
