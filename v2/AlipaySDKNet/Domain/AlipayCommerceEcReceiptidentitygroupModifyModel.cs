using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcReceiptidentitygroupModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcReceiptidentitygroupModifyModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("add_identity_list")]
        [XmlArrayItem("receipt_identity_info")]
        public List<ReceiptIdentityInfo> AddIdentityList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("delete_identity_list")]
        [XmlArrayItem("receipt_identity_info")]
        public List<ReceiptIdentityInfo> DeleteIdentityList { get; set; }

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

        /// <summary>
        /// 收单身份组名称
        /// </summary>
        [XmlElement("identity_group_name")]
        public string IdentityGroupName { get; set; }
    }
}
