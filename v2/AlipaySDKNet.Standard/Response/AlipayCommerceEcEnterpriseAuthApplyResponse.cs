using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAuthApplyResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseAuthApplyResponse : AopResponse
    {
        /// <summary>
        /// 企业认证申请记录ID
        /// </summary>
        [XmlElement("auth_apply_id")]
        public string AuthApplyId { get; set; }
    }
}
