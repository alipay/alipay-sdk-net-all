using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpCalcCondition Data Structure.
    /// </summary>
    [Serializable]
    public class VcpCalcCondition : AopObject
    {
        /// <summary>
        /// 前置条件，如买A送B这类优惠，A则是B享受优惠的前置条件
        /// </summary>
        [XmlArray("condition_item_ids")]
        [XmlArrayItem("string")]
        public List<string> ConditionItemIds { get; set; }

        /// <summary>
        /// 金额下限
        /// </summary>
        [XmlElement("from_amount")]
        public string FromAmount { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("from_time")]
        public string FromTime { get; set; }

        /// <summary>
        /// 商品Id列表
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 门槛金额类型
        /// </summary>
        [XmlElement("threshold_amount_type")]
        public string ThresholdAmountType { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("threshold_count")]
        public long ThresholdCount { get; set; }

        /// <summary>
        /// 金额上限
        /// </summary>
        [XmlElement("to_amount")]
        public string ToAmount { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("to_time")]
        public string ToTime { get; set; }
    }
}
