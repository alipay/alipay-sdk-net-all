using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiStageAmountConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MultiStageAmountConfigDTO : AopObject
    {
        /// <summary>
        /// 每期租金(单位元),最多2位小数
        /// </summary>
        [XmlElement("period_rent_amount")]
        public string PeriodRentAmount { get; set; }

        /// <summary>
        /// 分钟: MINUTE;小时: HOUR;
        /// </summary>
        [XmlElement("period_unit")]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// 例：每期时间单位是分钟, 每期时间数值15, 那就是每15分钟是一个计费周期
        /// </summary>
        [XmlElement("period_unit_num")]
        public long PeriodUnitNum { get; set; }
    }
}
