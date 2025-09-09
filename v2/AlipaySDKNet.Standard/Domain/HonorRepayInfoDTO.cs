using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorRepayInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorRepayInfoDTO : AopObject
    {
        /// <summary>
        /// 待还利息，单位：分
        /// </summary>
        [XmlElement("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 待还本金，单位：分
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 待还总额，单位：分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
