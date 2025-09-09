using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialGamecenterGamerightsConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialGamecenterGamerightsConsultModel : AopObject
    {
        /// <summary>
        /// 咨询权益数量
        /// </summary>
        [XmlElement("consult_right_num")]
        public long ConsultRightNum { get; set; }

        /// <summary>
        /// 咨询权益类型
        /// </summary>
        [XmlElement("consult_right_type")]
        public string ConsultRightType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
