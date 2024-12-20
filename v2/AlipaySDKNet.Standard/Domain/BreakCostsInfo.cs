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
        /// 当违约金类型是REMAIN_REATE时必传，需要设置违约金的收取按照剩余金额的多少比例计算，如30代表30%
        /// </summary>
        [XmlElement("damages_rate")]
        public string DamagesRate { get; set; }

        /// <summary>
        /// 违约金类型
        /// </summary>
        [XmlElement("damages_type")]
        public string DamagesType { get; set; }
    }
}
