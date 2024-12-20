using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpOperationAbnormalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpOperationAbnormalInfo : AopObject
    {
        /// <summary>
        /// 作出决定机关列入
        /// </summary>
        [XmlElement("decision_making_organ_in")]
        public string DecisionMakingOrganIn { get; set; }

        /// <summary>
        /// 作出决定机关(移出)
        /// </summary>
        [XmlElement("decision_making_organ_out")]
        public string DecisionMakingOrganOut { get; set; }

        /// <summary>
        /// 异常原因
        /// </summary>
        [XmlElement("error_reason")]
        public string ErrorReason { get; set; }

        /// <summary>
        /// 列入日期
        /// </summary>
        [XmlElement("in_date")]
        public string InDate { get; set; }

        /// <summary>
        /// 移出日期
        /// </summary>
        [XmlElement("out_date")]
        public string OutDate { get; set; }

        /// <summary>
        /// 移出原因
        /// </summary>
        [XmlElement("out_reason")]
        public string OutReason { get; set; }
    }
}
