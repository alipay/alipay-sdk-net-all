using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoActivitySignupModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoActivitySignupModel : AopObject
    {
        /// <summary>
        /// 活动唯一编码，固定值
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 场景编码，固定值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 报名信息，需传入JSON转义后的字符串
        /// </summary>
        [XmlElement("sign_up_info")]
        public string SignUpInfo { get; set; }

        /// <summary>
        /// 客户报名使用的支付宝账号
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 客户报名使用的支付宝账号类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
