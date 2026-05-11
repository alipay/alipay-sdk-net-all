using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateVerifyQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateVerifyQueryResponse : AopResponse
    {
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

        /// <summary>
        /// 用于标识一个完整请求，一个完整请求：查询链接-验证身份-完成验证
        /// </summary>
        [XmlElement("verify_request_id")]
        public string VerifyRequestId { get; set; }

        /// <summary>
        /// 验证状态，通过、不通过、验证中
        /// </summary>
        [XmlElement("verify_status")]
        public string VerifyStatus { get; set; }

        /// <summary>
        /// 验证的类型，学生/教职工
        /// </summary>
        [XmlElement("verify_type")]
        public string VerifyType { get; set; }
    }
}
