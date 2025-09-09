using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDialogueRatingSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDialogueRatingSubmitModel : AopObject
    {
        /// <summary>
        /// 功能编码，服务端会通过卡片传过来
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户反馈
        /// </summary>
        [XmlElement("feed_back_list")]
        public string FeedBackList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID；若是open_id时，设置为ALIPAY_OPENID
        /// </summary>
        [XmlElement("outer_user_type")]
        public string OuterUserType { get; set; }

        /// <summary>
        /// 用户评论
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 当前sessionId
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
