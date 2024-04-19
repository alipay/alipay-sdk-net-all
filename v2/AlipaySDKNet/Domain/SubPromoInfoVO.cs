using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubPromoInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SubPromoInfoVO : AopObject
    {
        /// <summary>
        /// 订单消耗的子代币数量
        /// </summary>
        [XmlElement("cost_count")]
        public string CostCount { get; set; }

        /// <summary>
        /// 订单消耗的子代币类型名称
        /// </summary>
        [XmlElement("sub_type_name")]
        public string SubTypeName { get; set; }
    }
}
