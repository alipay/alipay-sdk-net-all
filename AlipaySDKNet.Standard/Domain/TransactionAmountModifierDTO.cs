using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransactionAmountModifierDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TransactionAmountModifierDTO : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public TransactionAmountDTO Amount { get; set; }

        /// <summary>
        /// 金额类型说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 金额类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
