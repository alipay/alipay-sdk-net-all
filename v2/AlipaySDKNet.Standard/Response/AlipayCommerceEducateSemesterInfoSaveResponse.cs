using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSemesterInfoSaveResponse.
    /// </summary>
    public class AlipayCommerceEducateSemesterInfoSaveResponse : AopResponse
    {
        /// <summary>
        /// 学期ID
        /// </summary>
        [XmlElement("semester_id")]
        public string SemesterId { get; set; }
    }
}
