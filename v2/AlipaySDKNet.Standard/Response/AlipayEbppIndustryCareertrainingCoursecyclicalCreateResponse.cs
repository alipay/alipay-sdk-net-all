using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCoursecyclicalCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingCoursecyclicalCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
