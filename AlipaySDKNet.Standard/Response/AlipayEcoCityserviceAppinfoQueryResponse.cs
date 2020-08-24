using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceAppinfoQueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceAppinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 业务返回结果上下文
        /// </summary>
        [XmlElement("result_context")]
        public string ResultContext { get; set; }

        /// <summary>
        /// 业务返回错误
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
