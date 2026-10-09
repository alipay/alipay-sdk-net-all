using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneProductInquiryApplyResponse.
    /// </summary>
    public class AlipayInsSceneProductInquiryApplyResponse : AopResponse
    {
        /// <summary>
        /// 保险产品保费值，金额类型(单位为分)
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }
    }
}
