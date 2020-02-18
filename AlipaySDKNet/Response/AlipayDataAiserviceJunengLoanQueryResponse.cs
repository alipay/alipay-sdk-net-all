using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceJunengLoanQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceJunengLoanQueryResponse : AopResponse
    {
        /// <summary>
        /// 二级错误码，帮助诊断错误
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 用户身份证的md5加密值
        /// </summary>
        [XmlElement("hashed_cert_no")]
        public string HashedCertNo { get; set; }

        /// <summary>
        /// 本次请求的uuid
        /// </summary>
        [XmlElement("request_uuid")]
        public string RequestUuid { get; set; }

        /// <summary>
        /// 接口的返回结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
