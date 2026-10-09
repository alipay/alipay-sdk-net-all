using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskHahaIsptestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskHahaIsptestQueryModel : AopObject
    {
        /// <summary>
        /// 简单复杂类型
        /// </summary>
        [XmlElement("test_five")]
        public InsurancePeriod TestFive { get; set; }

        /// <summary>
        /// 高级复杂类型
        /// </summary>
        [XmlElement("test_four")]
        public RecomProduct TestFour { get; set; }

        /// <summary>
        /// 2088
        /// </summary>
        [XmlElement("test_one")]
        public string TestOne { get; set; }

        /// <summary>
        /// 入参3
        /// </summary>
        [XmlArray("test_three")]
        [XmlArrayItem("string")]
        public List<string> TestThree { get; set; }

        /// <summary>
        /// 123456
        /// </summary>
        [XmlElement("test_two")]
        public string TestTwo { get; set; }
    }
}
