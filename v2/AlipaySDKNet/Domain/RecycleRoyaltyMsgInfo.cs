using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleRoyaltyMsgInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleRoyaltyMsgInfo : AopObject
    {
        /// <summary>
        /// 金额单位元，支持小数点后2位，必须大于0
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账转入的账号
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }
    }
}
