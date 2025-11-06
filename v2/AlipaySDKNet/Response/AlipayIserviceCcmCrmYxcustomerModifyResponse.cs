using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmCrmYxcustomerModifyResponse.
    /// </summary>
    public class AlipayIserviceCcmCrmYxcustomerModifyResponse : AopResponse
    {
        /// <summary>
        /// 更新的联系人列表
        /// </summary>
        [XmlArray("contact_info_list")]
        [XmlArrayItem("yx_contact_info")]
        public List<YxContactInfo> ContactInfoList { get; set; }

        /// <summary>
        /// 客户记录的ID
        /// </summary>
        [XmlElement("data_id")]
        public long DataId { get; set; }
    }
}
