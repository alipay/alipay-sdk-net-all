using System;
using System.Xml.Serialization;

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
        [XmlElement("data")]
        public MetroOdItem Data { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
