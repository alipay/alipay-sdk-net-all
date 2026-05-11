using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskVerifyidentityVoiceprintRecommendModel : AopObject
    {
        /// <summary>
        /// 回调URL
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 推荐类型，仅支持consult或render，consult表示咨询是否推荐，render表示获取推荐详情
        /// </summary>
        [XmlElement("recommend_type")]
        public string RecommendType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
