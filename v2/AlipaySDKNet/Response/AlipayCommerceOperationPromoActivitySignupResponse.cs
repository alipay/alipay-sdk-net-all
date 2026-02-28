using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoActivitySignupResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoActivitySignupResponse : AopResponse
    {
        /// <summary>
        /// 报名返回
        /// </summary>
        [XmlElement("sign_up_data")]
        public string SignUpData { get; set; }
    }
}
