using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenContentUsereventcontentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenContentUsereventcontentQueryModel : AopObject
    {
        /// <summary>
        /// 请求唯一标识，用于全链路追踪，UUID 格式
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 厂商触发事件信息
        /// </summary>
        [XmlElement("smartphone_vendors_event_info")]
        public SmartphoneVendorsEventInfo SmartphoneVendorsEventInfo { get; set; }

        /// <summary>
        /// 手机厂商用户唯一标识
        /// </summary>
        [XmlElement("smartphone_vendors_user_identity")]
        public SmartphoneVendorsUserIdentity SmartphoneVendorsUserIdentity { get; set; }

        /// <summary>
        /// 手机厂商厂商标识
        /// </summary>
        [XmlElement("vendor")]
        public string Vendor { get; set; }
    }
}
