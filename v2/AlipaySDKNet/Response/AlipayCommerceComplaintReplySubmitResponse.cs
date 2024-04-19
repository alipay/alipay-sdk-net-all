using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceComplaintReplySubmitResponse.
    /// </summary>
    public class AlipayCommerceComplaintReplySubmitResponse : AopResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("res")]
        public bool Res { get; set; }
    }
}
