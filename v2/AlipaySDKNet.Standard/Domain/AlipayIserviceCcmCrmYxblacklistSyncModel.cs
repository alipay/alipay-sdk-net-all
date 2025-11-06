using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmYxblacklistSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmYxblacklistSyncModel : AopObject
    {
        /// <summary>
        /// 黑名单的备注信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 黑名单失效时间
        /// </summary>
        [XmlElement("invalid_time")]
        public long InvalidTime { get; set; }

        /// <summary>
        /// 黑名单手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [XmlElement("take_time")]
        public long TakeTime { get; set; }

        /// <summary>
        /// 租户ID，由蚂蚁侧提供给调用方
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 黑名单客户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
