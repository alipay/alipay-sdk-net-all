using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBankcardCertificationQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalBankcardCertificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行卡是否绑定查询的出参
        /// </summary>
        [XmlElement("data")]
        public CommerceMedicalBankcardCertificationQueryData Data { get; set; }

        /// <summary>
        /// 业务处理结果描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务处理结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
