using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBaseorderModifyResponse.
    /// </summary>
    public class AlipayOpenSearchBaseorderModifyResponse : AopResponse
    {
        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
