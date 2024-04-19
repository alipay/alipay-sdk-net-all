using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordApplyResponse.
    /// </summary>
    public class AlipayOpenSearchAppkeywordApplyResponse : AopResponse
    {
        /// <summary>
        /// 提报之后的后台审核工单的id
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
