using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuInsuclaimAttachmentQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrcominsuInsuclaimAttachmentQueryResponse : AopResponse
    {
        /// <summary>
        /// attachment_stream+不唯一+供应商获取理赔附件+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("attachment_stream")]
        public string AttachmentStream { get; set; }
    }
}
