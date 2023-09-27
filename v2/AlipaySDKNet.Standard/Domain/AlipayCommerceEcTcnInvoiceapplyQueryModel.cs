using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTcnInvoiceapplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTcnInvoiceapplyQueryModel : AopObject
    {
        /// <summary>
        /// 开票申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 平台申请ID
        /// </summary>
        [XmlElement("platform_apply_id")]
        public string PlatformApplyId { get; set; }
    }
}
