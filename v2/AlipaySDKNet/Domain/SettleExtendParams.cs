using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class SettleExtendParams : AopObject
    {
        /// <summary>
        /// 本笔交易的分账操作是否已完结，可传入的值：true/false。 如果指定完结分账，则本次分账处理完成后会把该笔交易的剩余冻结金额全额解冻；
        /// </summary>
        [XmlElement("royalty_finish")]
        public string RoyaltyFinish { get; set; }
    }
}
