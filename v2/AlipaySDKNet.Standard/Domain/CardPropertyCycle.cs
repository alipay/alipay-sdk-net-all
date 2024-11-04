using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardPropertyCycle Data Structure.
    /// </summary>
    [Serializable]
    public class CardPropertyCycle : AopObject
    {
        /// <summary>
        /// 指定周期付首期扣款的方式
        /// </summary>
        [XmlElement("cycle_charge_type")]
        public string CycleChargeType { get; set; }

        /// <summary>
        /// 根据周期计费类型来传递参数值 1.固定日期开始扣费，需要传入周几（1-7）或每月几号（1-28）开始扣费
        /// </summary>
        [XmlElement("cycle_value")]
        public string CycleValue { get; set; }
    }
}
