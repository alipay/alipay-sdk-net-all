using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepositRuleBizParam Data Structure.
    /// </summary>
    [Serializable]
    public class DepositRuleBizParam : AopObject
    {
        /// <summary>
        /// 是否发内部消息
        /// </summary>
        [XmlElement("need_send_inner_msg")]
        public bool NeedSendInnerMsg { get; set; }
    }
}
