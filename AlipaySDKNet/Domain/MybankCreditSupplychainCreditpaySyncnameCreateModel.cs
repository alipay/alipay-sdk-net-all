using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySyncnameCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainCreditpaySyncnameCreateModel : AopObject
    {
        /// <summary>
        /// 报名时间/取消时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 渠道标签
        /// </summary>
        [XmlElement("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 操作类型: APPLY:报名申请; CANCEL:取消报名
        /// </summary>
        [XmlElement("handle_type")]
        public string HandleType { get; set; }

        /// <summary>
        /// 营销结束时间
        /// </summary>
        [XmlElement("promo_end_time")]
        public string PromoEndTime { get; set; }

        /// <summary>
        /// 营销开始时间
        /// </summary>
        [XmlElement("promo_start_time")]
        public string PromoStartTime { get; set; }

        /// <summary>
        /// 营销类型, 长账期:LONG_TERM
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 营销值, 长账期:2
        /// </summary>
        [XmlElement("promo_value")]
        public string PromoValue { get; set; }

        /// <summary>
        /// 请求幂等控制ID，以isv的ipRoleId_为前缀
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 1688商铺ID
        /// </summary>
        [XmlElement("scene_user_id")]
        public string SceneUserId { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [XmlElement("seller")]
        public Member Seller { get; set; }
    }
}
