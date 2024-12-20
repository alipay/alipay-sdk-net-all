using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportshealthQuestionnaireCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportshealthQuestionnaireCompleteModel : AopObject
    {
        /// <summary>
        /// 业务唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 问卷调查结果
        /// </summary>
        [XmlElement("survey_result")]
        public string SurveyResult { get; set; }

        /// <summary>
        /// 调查类型
        /// </summary>
        [XmlElement("survey_type")]
        public string SurveyType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
