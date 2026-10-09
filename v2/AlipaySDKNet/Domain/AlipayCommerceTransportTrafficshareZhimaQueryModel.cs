using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTrafficshareZhimaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTrafficshareZhimaQueryModel : AopObject
    {
        /// <summary>
        /// 用户设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 用户设备IP
        /// </summary>
        [XmlElement("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户外部协议号，全局唯一协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone_num")]
        public string PhoneNum { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 开通芝麻先享成功后待跳转的商户页面url
        /// </summary>
        [XmlElement("skip_link_url")]
        public string SkipLinkUrl { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
