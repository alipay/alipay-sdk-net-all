using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmFunctionFilter Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmFunctionFilter : AopObject
    {
        /// <summary>
        /// 过滤类型  - literal_or(白名单)  - not_literal_or(黑名单)
        /// </summary>
        [XmlElement("filter_type")]
        public string FilterType { get; set; }

        /// <summary>
        /// 函数名称列表
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("string")]
        public List<string> Functions { get; set; }
    }
}
