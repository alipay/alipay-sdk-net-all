using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserChangeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserChangeSyncModel : AopObject
    {
        /// <summary>
        /// 开通/授权协议号
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 白鹭分评估时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 是否新开通用户 Y：新开通 N：非新开通
        /// </summary>
        [XmlElement("is_new_open")]
        public string IsNewOpen { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求唯一单号，每次请求要保持唯一不重复
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 白鹭分等级（极好/优秀/良好/中等/待提升）
        /// </summary>
        [XmlElement("score_level")]
        public string ScoreLevel { get; set; }

        /// <summary>
        /// 信用服务service_id； 芝麻侧通过商户PID生成的一个信用服务的id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 例如厦门白鹭分：710分
        /// </summary>
        [XmlElement("user_score")]
        public string UserScore { get; set; }
    }
}
