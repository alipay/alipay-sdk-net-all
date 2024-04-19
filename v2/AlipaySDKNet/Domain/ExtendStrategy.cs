using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtendStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendStrategy : AopObject
    {
        /// <summary>
        /// 账户信息
        /// </summary>
        [XmlElement("participant_form")]
        public ParticipantForm ParticipantForm { get; set; }

        /// <summary>
        /// 提现策略，当前支持同人账户提现（策略key: withdrawToSamePersonAccount）
        /// </summary>
        [XmlElement("strategy")]
        public string Strategy { get; set; }
    }
}
