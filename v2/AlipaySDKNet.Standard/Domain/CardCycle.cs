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
        /// 1.当该参数配置为true时，在用户下单时立即扣第一期的金额 2.默认没有权限，需要找客户经理申请权限
        /// </summary>
        [XmlElement("charge_now")]
        public bool ChargeNow { get; set; }

        /// <summary>
        /// 指定周期付首期扣款的方式
        /// </summary>
        [XmlElement("cycle_charge_type")]
        public string CycleChargeType { get; set; }

        /// <summary>
        /// 表示固定周期扣费的步长，比如28表示每隔28个自然日扣费。
        /// </summary>
        [XmlElement("cycle_range")]
        public long CycleRange { get; set; }

        /// <summary>
        /// 指定周期付的周期单位
        /// </summary>
        [XmlElement("cycle_type")]
        public string CycleType { get; set; }

        /// <summary>
        /// 根据周期计费类型来传递参数值 1.固定日期开始扣费，需要传入周几（1-7）或每月几号（1-28）开始扣费 2.指定固定天数后开始扣费，需要传入具体多少天（0-60）
        /// </summary>
        [XmlElement("cycle_value")]
        public string CycleValue { get; set; }

        /// <summary>
        /// 周期卡商品类型，用于业务标识，年卡/季卡 当前字段已废弃(支持自定义期数，不需要该字段)
        /// </summary>
        [XmlElement("period_item_type")]
        public string PeriodItemType { get; set; }

        /// <summary>
        /// 周期计费类型为USER_DESIGN，即用户可指定固定日期开始扣费的场景下，商家可以控制用户下单可选择时间范围。 值的范围是[0,26]：如下单时用户只能选0-30天范围内的时间作为首期计费时间，则该参数传0。如下单时用户只能选15-30天范围内的时间作为首期计费时间，则该参数传15。
        /// </summary>
        [XmlElement("user_select_range_start")]
        public string UserSelectRangeStart { get; set; }
    }
}
