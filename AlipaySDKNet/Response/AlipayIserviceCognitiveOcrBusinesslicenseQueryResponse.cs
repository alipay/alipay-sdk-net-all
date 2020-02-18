using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBusinesslicenseQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrBusinesslicenseQueryResponse : AopResponse
    {
        /// <summary>
        /// 住所
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("business")]
        public string Business { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("captial")]
        public string Captial { get; set; }

        /// <summary>
        /// 识别错误情况下的，详细错误原因
        /// </summary>
        [XmlElement("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("establish_date")]
        public string EstablishDate { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("person")]
        public string Person { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("reg_num")]
        public string RegNum { get; set; }

        /// <summary>
        /// 服务器id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// true: 识别成功  false：识别失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        [XmlElement("valid_period")]
        public string ValidPeriod { get; set; }
    }
}
