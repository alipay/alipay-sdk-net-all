using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateVerifyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateVerifyConsultModel : AopObject
    {
        /// <summary>
        /// 用于传递此次验证的基本信息
        /// </summary>
        [XmlElement("verify_info")]
        public VerifyOrderInfo VerifyInfo { get; set; }

        /// <summary>
        /// 用于标识一个完整请求，一个完整请求：查询链接-验证身份-完成验证
        /// </summary>
        [XmlElement("verify_request_id")]
        public string VerifyRequestId { get; set; }
    }
}
