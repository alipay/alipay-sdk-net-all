using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Liability Data Structure.
    /// </summary>
    [Serializable]
    public class Liability : AopObject
    {
        /// <summary>
        /// 是否投保不计免赔，0-否，1-是
        /// </summary>
        [XmlElement("iop")]
        public string Iop { get; set; }

        /// <summary>
        /// 标准责任编码
        /// </summary>
        [XmlElement("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 保额，单位分(分金额类的保额和枚举类的保额，注意参考数据字典)
        /// </summary>
        [XmlElement("sum_insured")]
        public string SumInsured { get; set; }
    }
}
