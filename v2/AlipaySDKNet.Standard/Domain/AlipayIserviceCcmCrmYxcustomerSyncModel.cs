using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmYxcustomerSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmYxcustomerSyncModel : AopObject
    {
        /// <summary>
        /// 客户联系人信息，至少有1个
        /// </summary>
        [XmlArray("contact_info_list")]
        [XmlArrayItem("yx_contact_info")]
        public List<YxContactInfo> ContactInfoList { get; set; }

        /// <summary>
        /// 客户ID，非客户信息的ID，同外部系统的关联项
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户信息的额外信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
