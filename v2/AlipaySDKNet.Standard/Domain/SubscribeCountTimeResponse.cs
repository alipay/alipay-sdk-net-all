using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscribeCountTimeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SubscribeCountTimeResponse : AopObject
    {
        /// <summary>
        /// 计次是否成功
        /// </summary>
        [XmlElement("count_success")]
        public bool CountSuccess { get; set; }
    }
}
