using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseRegisterApplyResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseRegisterApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
