using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardAuthQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 医保电子凭证或电子社保卡信息
        /// </summary>
        [XmlElement("data")]
        public MedicalCardInfoList Data { get; set; }

        /// <summary>
        /// 接口错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
