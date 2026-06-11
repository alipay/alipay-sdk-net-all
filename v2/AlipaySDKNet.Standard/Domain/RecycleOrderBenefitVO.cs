using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOrderBenefitVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOrderBenefitVO : AopObject
    {
        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 权益发放节点
        /// </summary>
        [XmlElement("benefit_node")]
        public string BenefitNode { get; set; }

        /// <summary>
        /// 权益数量
        /// </summary>
        [XmlElement("benefit_num")]
        public string BenefitNum { get; set; }

        /// <summary>
        /// 权益状态
        /// </summary>
        [XmlElement("benefit_status")]
        public string BenefitStatus { get; set; }

        /// <summary>
        /// 权益子类型
        /// </summary>
        [XmlElement("benefit_sub_type")]
        public string BenefitSubType { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 单位类型
        /// </summary>
        [XmlElement("unit_type")]
        public string UnitType { get; set; }
    }
}
