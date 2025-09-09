using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BreakCostsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BreakCostsInfo : AopObject
    {
        /// <summary>
        /// 卡到期后是否收取违约金，默认01
        /// </summary>
        [XmlElement("break_costs_expired")]
        public string BreakCostsExpired { get; set; }

        /// <summary>
        /// 7天内退卡是否收取违约金，默认02
        /// </summary>
        [XmlElement("break_costs_seven_days")]
        public string BreakCostsSevenDays { get; set; }

        /// <summary>
        /// 当违约金类型是REMAIN_RATE时必传，需要设置违约金的收取按照剩余金额的多少比例计算，如30代表30%
        /// </summary>
        [XmlElement("damages_rate")]
        public string DamagesRate { get; set; }

        /// <summary>
        /// 违约金类型
        /// </summary>
        [XmlElement("damages_type")]
        public string DamagesType { get; set; }

        /// <summary>
        /// 用于设置是否支持免违约金规则
        /// </summary>
        [XmlElement("no_break_costs_flag")]
        public string NoBreakCostsFlag { get; set; }

        /// <summary>
        /// 免违约金单位，无需传参，后台根据卡类型自动设置值。
        /// </summary>
        [XmlElement("no_break_costs_unit")]
        public string NoBreakCostsUnit { get; set; }

        /// <summary>
        /// 免违约金额（单位元）/次数/期数
        /// </summary>
        [XmlElement("no_break_costs_value")]
        public string NoBreakCostsValue { get; set; }
    }
}
