using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenNppdUserpointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenNppdUserpointQueryModel : AopObject
    {
        /// <summary>
        /// 企业分配给阿里云的Code
        /// </summary>
        [XmlElement("merchant_code")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// 企业提供的参数
        /// </summary>
        [XmlElement("merchant_exts")]
        public string MerchantExts { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 企业侧的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
