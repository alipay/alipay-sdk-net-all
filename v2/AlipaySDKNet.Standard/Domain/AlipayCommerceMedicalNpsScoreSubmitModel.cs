using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalNpsScoreSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalNpsScoreSubmitModel : AopObject
    {
        /// <summary>
        /// 业务信息
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 反馈信息
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
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 评级
        /// </summary>
        [XmlElement("rating_type")]
        public string RatingType { get; set; }

        /// <summary>
        /// 用户输入反馈信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 评分 1 - 10
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 当前对话的seesionId
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
