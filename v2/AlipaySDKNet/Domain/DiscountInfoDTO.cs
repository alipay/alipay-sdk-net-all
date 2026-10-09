using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountInfoDTO : AopObject
    {
        /// <summary>
        /// 封顶金额
        /// </summary>
        [XmlElement("ceiling_amount")]
        public Amount CeilingAmount { get; set; }

        /// <summary>
        /// 折扣比例,8这使用0.8
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

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
    }
}
