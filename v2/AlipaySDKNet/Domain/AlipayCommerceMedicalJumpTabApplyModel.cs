using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalJumpTabApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalJumpTabApplyModel : AopObject
    {
        /// <summary>
        /// 请求来源的字符串
        /// </summary>
        [XmlElement("from_source")]
        public string FromSource { get; set; }

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
