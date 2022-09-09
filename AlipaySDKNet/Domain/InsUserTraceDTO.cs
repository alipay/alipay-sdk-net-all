using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsUserTraceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsUserTraceDTO : AopObject
    {
        /// <summary>
        /// 回溯动作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 其他回溯的扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// action对应的操作对象
        /// </summary>
        [XmlElement("object")]
        public string Object { get; set; }

        /// <summary>
        /// 触发时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
