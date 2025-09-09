using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateLeaveuserAddResponse.
    /// </summary>
    public class AlipayCommerceEducateLeaveuserAddResponse : AopResponse
    {
        /// <summary>
        /// 请假申请单号
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
