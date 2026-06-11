using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryEducertifyTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryEducertifyTokenCreateModel : AopObject
    {
        /// <summary>
        /// 业务ID,一般为UUID字符串
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
