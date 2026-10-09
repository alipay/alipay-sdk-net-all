using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Argument Data Structure.
    /// </summary>
    [Serializable]
    public class Argument : AopObject
    {
        /// <summary>
        /// 用户的自定义参数内容
        /// </summary>
        [XmlElement("args")]
        public string Args { get; set; }

        /// <summary>
        /// 更新时间（格式为时间戳）
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 该字段为自定义参数的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
