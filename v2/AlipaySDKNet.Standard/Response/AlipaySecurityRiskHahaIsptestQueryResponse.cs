using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskHahaIsptestQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskHahaIsptestQueryResponse : AopResponse
    {
        /// <summary>
        /// 高级复杂类型
        /// </summary>
        [XmlArray("out_four")]
        [XmlArrayItem("recom_product")]
        public List<RecomProduct> OutFour { get; set; }

        /// <summary>
        /// 23
        /// </summary>
        [XmlElement("out_one")]
        public string OutOne { get; set; }

        /// <summary>
        /// 简单复杂类型
        /// </summary>
        [XmlArray("out_three")]
        [XmlArrayItem("insurance_period")]
        public List<InsurancePeriod> OutThree { get; set; }

        /// <summary>
        /// 出参2
        /// </summary>
        [XmlArray("out_two")]
        [XmlArrayItem("string")]
        public List<string> OutTwo { get; set; }
    }
}
