using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenPolicyLiabilityDigestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenPolicyLiabilityDigestDTO : AopObject
    {
        /// <summary>
        /// 蚂蚁保某个保险产品的责任名称
        /// </summary>
        [XmlElement("liability_name")]
        public string LiabilityName { get; set; }

        /// <summary>
        /// 蚂蚁保分配的某个保险产品的责任编号
        /// </summary>
        [XmlElement("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 责任保额，单位分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
