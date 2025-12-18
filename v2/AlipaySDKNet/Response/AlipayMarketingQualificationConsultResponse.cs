using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQualificationConsultResponse.
    /// </summary>
    public class AlipayMarketingQualificationConsultResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("qualification")]
        public List<Qualification> Qualifications { get; set; }
    }
}
