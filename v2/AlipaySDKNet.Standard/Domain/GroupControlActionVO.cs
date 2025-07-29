using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupControlActionVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupControlActionVO : AopObject
    {
        /// <summary>
        /// 命中处理方式
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 警告语
        /// </summary>
        [XmlElement("warn_msg")]
        public string WarnMsg { get; set; }
    }
}
