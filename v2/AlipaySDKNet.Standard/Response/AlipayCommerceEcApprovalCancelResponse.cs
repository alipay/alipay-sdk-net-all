using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcApprovalCancelResponse.
    /// </summary>
    public class AlipayCommerceEcApprovalCancelResponse : AopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
