using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoContractsLoanAuthSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoContractsLoanAuthSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户授权状态，true代表同意授权，false代表不同意授权
        /// </summary>
        [XmlElement("auth_status")]
        public bool AuthStatus { get; set; }

        /// <summary>
        /// 免费份额发放时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("free_portion_grant_time")]
        public long FreePortionGrantTime { get; set; }

        /// <summary>
        /// 免费份额使用时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("free_portion_used_time")]
        public long FreePortionUsedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部商户下用户的唯一标识
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 同步请求id，幂等使用
        /// </summary>
        [XmlElement("sync_request_id")]
        public string SyncRequestId { get; set; }
    }
}
