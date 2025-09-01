using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingOrginfoModifyResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingOrginfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }
    }
}
