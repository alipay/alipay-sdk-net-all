using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchServiceorderModifyResponse.
    /// </summary>
    public class AlipayOpenSearchServiceorderModifyResponse : AopResponse
    {
        /// <summary>
        /// 申请单的申请单id，applyid
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
