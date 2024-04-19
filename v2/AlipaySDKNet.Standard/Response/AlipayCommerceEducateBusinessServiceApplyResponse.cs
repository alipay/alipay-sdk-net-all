using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateBusinessServiceApplyResponse.
    /// </summary>
    public class AlipayCommerceEducateBusinessServiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 学校编号
        /// </summary>
        [XmlElement("school_no")]
        public string SchoolNo { get; set; }
    }
}
