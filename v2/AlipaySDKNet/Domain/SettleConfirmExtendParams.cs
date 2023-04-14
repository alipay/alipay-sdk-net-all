using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleConfirmExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class SettleConfirmExtendParams : AopObject
    {
        /// <summary>
        /// 是否进行资金冻结，用于后续分账，true表示冻结，false或不传表示不冻结
        /// </summary>
        [XmlElement("royalty_freeze")]
        public string RoyaltyFreeze { get; set; }
    }
}
