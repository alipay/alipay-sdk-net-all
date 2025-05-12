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
        /// 提现策略。 withdrawToSamePersonAccount仅支持支付宝已注销，但是场景钱包仍有余额的情况； withdrawToSameCidAccount支持同CID，且双方支付宝未注销时，场景钱包提现到同CID支付宝余额。
        /// </summary>
        [XmlElement("strategy")]
        public string Strategy { get; set; }
    }
}
