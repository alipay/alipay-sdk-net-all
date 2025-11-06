using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmYxcustomerModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmYxcustomerModifyModel : AopObject
    {
        /// <summary>
        /// 要更新的联系人信息
        /// </summary>
        [XmlArray("contact_info_list")]
        [XmlArrayItem("yx_contact_info")]
        public List<YxContactInfo> ContactInfoList { get; set; }

        /// <summary>
        /// 客户记录的ID
        /// </summary>
        [XmlElement("data_id")]
        public long DataId { get; set; }

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
