using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardCycle Data Structure.
    /// </summary>
    [Serializable]
    public class CardCycle : AopObject
    {
        /// <summary>
        /// 指定周期付首期扣款的方式
        /// </summary>
        [XmlElement("cycle_charge_type")]
        public string CycleChargeType { get; set; }

        /// <summary>
        /// 指定周期付的周期单位
        /// </summary>
        [XmlElement("cycle_type")]
        public string CycleType { get; set; }

        /// <summary>
        /// 根据周期计费类型来传递参数值 1.固定日期开始扣费，需要传入周几（1-7）或每月几号（1-28）开始扣费 2.指定固定天数后开始扣费，需要传入具体多少天（0-30）
        /// </summary>
        [XmlElement("cycle_value")]
        public string CycleValue { get; set; }

        /// <summary>
        /// 周期计费类型为USER_DESIGN，即用户可指定固定日期开始扣费的场景下，商家可以控制用户下单可选择时间范围，如下单时用户只能选0-30天范围内的时间作为首期计费时间，则该参数传0
        /// </summary>
        [XmlElement("user_select_range_start")]
        public string UserSelectRangeStart { get; set; }
    }
}
