using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MetroOdDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class MetroOdDetailResult : AopObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("metro_od_item")]
        public List<MetroOdItem> Data { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
