using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducatePeriodInfoSaveResponse.
    /// </summary>
    public class AlipayCommerceEducatePeriodInfoSaveResponse : AopResponse
    {
        /// <summary>
        /// 课时ID
        /// </summary>
        [XmlElement("period_id")]
        public string PeriodId { get; set; }
    }
}
