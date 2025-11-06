using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmCrmYxcustomerSyncResponse.
    /// </summary>
    public class AlipayIserviceCcmCrmYxcustomerSyncResponse : AopResponse
    {
        /// <summary>
        /// 客户联系方式列表，至少会有1个
        /// </summary>
        [XmlElement("contact_info_list")]
        public YxContactInfo ContactInfoList { get; set; }

        /// <summary>
        /// 客户记录的ID
        /// </summary>
        [XmlElement("data_id")]
        public long DataId { get; set; }
    }
}
