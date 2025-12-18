using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationShangouAuthinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationShangouAuthinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 手机号绑定状态
        /// </summary>
        [XmlElement("mobile_binding_status")]
        public string MobileBindingStatus { get; set; }
    }
}
