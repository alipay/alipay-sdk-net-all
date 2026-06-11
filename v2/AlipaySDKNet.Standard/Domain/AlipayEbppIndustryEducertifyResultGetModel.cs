using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryEducertifyResultGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryEducertifyResultGetModel : AopObject
    {
        /// <summary>
        /// 业务ID,一般为UUID字符串,与获取certify_token时上传的业务ID保持一致。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 市民中心档案保险箱授权票据，非市民中心档案保险箱授权不用填
        /// </summary>
        [XmlElement("certify_auth_code")]
        public string CertifyAuthCode { get; set; }

        /// <summary>
        /// 业务票据
        /// </summary>
        [XmlElement("certify_token")]
        public string CertifyToken { get; set; }

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
