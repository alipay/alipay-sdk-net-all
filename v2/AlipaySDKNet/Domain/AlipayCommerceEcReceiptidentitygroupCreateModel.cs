using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcReceiptidentitygroupCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcReceiptidentitygroupCreateModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 收单身份组名称
        /// </summary>
        [XmlElement("identity_group_name")]
        public string IdentityGroupName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("identity_list")]
        [XmlArrayItem("receipt_identity_info")]
        public List<ReceiptIdentityInfo> IdentityList { get; set; }
    }
}
