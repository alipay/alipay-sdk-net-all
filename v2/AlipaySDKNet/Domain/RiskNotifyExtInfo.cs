using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskNotifyExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RiskNotifyExtInfo : AopObject
    {
        /// <summary>
        /// 同步的消息ID
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
