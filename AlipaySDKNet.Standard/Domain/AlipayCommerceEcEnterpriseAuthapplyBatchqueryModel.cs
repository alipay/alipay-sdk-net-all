using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAuthapplyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseAuthapplyBatchqueryModel : AopObject
    {
        /// <summary>
        /// 企业认证申请记录ID
        /// </summary>
        [XmlElement("auth_apply_id")]
        public string AuthApplyId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
