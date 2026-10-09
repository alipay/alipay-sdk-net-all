using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerZmcardIdentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerZmcardIdentityQueryModel : AopObject
    {
        /// <summary>
        /// 访客支付宝open_id，与guest_uid二选一
        /// </summary>
        [XmlElement("guest_open_id")]
        public string GuestOpenId { get; set; }

        /// <summary>
        /// 访客uid，如果是主态访问，与host_uid保持一致。如果不填，默认是客态访问；
        /// </summary>
        [XmlElement("guest_uid")]
        public string GuestUid { get; set; }

        /// <summary>
        /// 持证人支付宝openId，与host_uid二选一
        /// </summary>
        [XmlElement("host_open_id")]
        public string HostOpenId { get; set; }

        /// <summary>
        /// 持证人支付宝uid
        /// </summary>
        [XmlElement("host_uid")]
        public string HostUid { get; set; }

        /// <summary>
        /// 角色身份类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
