using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpCalcRule Data Structure.
    /// </summary>
    [Serializable]
    public class VcpCalcRule : AopObject
    {
        /// <summary>
        /// 计算条件
        /// </summary>
        [XmlElement("calc_condition")]
        public VcpCalcCondition CalcCondition { get; set; }

        /// <summary>
        /// 计算公式
        /// </summary>
        [XmlElement("calc_formula")]
        public VcpCalcFormula CalcFormula { get; set; }
    }
}
