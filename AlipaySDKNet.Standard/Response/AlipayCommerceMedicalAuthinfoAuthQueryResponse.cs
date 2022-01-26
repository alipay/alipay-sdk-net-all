using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAuthinfoAuthQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAuthinfoAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 国家医保局线上业务身份核验授权信息
        /// </summary>
        [XmlElement("data")]
        public MedicalNationalPayAuthInfo Data { get; set; }

        /// <summary>
        /// 业务错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
