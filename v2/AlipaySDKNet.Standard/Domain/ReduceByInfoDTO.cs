using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReduceByInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceByInfoDTO : AopObject
    {
        /// <summary>
        /// 权益的价值
        /// </summary>
        [XmlElement("amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// 消费最低金额限制
        /// </summary>
        [XmlElement("floor_amount")]
        public Amount FloorAmount { get; set; }
    }
}
