using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReduceToInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceToInfoDTO : AopObject
    {
        /// <summary>
        /// 消费最低金额限制
        /// </summary>
        [XmlElement("floor_amount")]
        public Amount FloorAmount { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("origin_amount")]
        public Amount OriginAmount { get; set; }

        /// <summary>
        /// 特价
        /// </summary>
        [XmlElement("special_amount")]
        public Amount SpecialAmount { get; set; }
    }
}
