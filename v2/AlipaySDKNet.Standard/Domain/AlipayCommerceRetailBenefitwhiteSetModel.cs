using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitwhiteSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitwhiteSetModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 操作员信息
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("verify_tester_list")]
        [XmlArrayItem("string")]
        public List<string> VerifyTesterList { get; set; }
    }
}
