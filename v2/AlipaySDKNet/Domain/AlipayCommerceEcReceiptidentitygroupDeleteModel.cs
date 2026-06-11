using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcReceiptidentitygroupDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcReceiptidentitygroupDeleteModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 收单身份组id
        /// </summary>
        [XmlElement("identity_group_id")]
        public string IdentityGroupId { get; set; }
    }
}
