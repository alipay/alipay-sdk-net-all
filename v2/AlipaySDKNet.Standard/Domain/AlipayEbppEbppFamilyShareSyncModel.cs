using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppFamilyShareSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppFamilyShareSyncModel : AopObject
    {
        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 共享权益的失效时间
        /// </summary>
        [XmlElement("share_expired")]
        public string ShareExpired { get; set; }

        /// <summary>
        /// 被分享人支付share_open_id
        /// </summary>
        [XmlElement("share_open_id")]
        public string ShareOpenId { get; set; }

        /// <summary>
        /// 共享处理过程的失效时间
        /// </summary>
        [XmlElement("share_sku_expired")]
        public string ShareSkuExpired { get; set; }

        /// <summary>
        /// 被分享人账号, 如被分享人账号是手机号则为11位手机号
        /// </summary>
        [XmlElement("share_target")]
        public string ShareTarget { get; set; }

        /// <summary>
        /// 被共享权益的失效时间
        /// </summary>
        [XmlElement("share_target_expire")]
        public string ShareTargetExpire { get; set; }

        /// <summary>
        /// 分享主账号类型
        /// </summary>
        [XmlElement("share_target_type")]
        public string ShareTargetType { get; set; }

        /// <summary>
        /// 被分享人支付宝UID
        /// </summary>
        [XmlElement("share_uid")]
        public string ShareUid { get; set; }

        /// <summary>
        /// 共享权益的商品SKUID
        /// </summary>
        [XmlElement("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// 分享状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 主购买人支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
