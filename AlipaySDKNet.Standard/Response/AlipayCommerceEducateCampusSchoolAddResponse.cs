using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusSchoolAddResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusSchoolAddResponse : AopResponse
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
