using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthUserParticipateCertifyResponse.
    /// </summary>
    public class AlipayFinancialnetAuthUserParticipateCertifyResponse : AopResponse
    {
        /// <summary>
        /// 认证成功的id， 如果未认证成功 则返回为空。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 以旧换新接口实名认证校验失败，会返回source对应类型的认证链接。注：动态字段biz_code是根据source映射的。
        /// </summary>
        [XmlElement("certify_url")]
        public string CertifyUrl { get; set; }

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
