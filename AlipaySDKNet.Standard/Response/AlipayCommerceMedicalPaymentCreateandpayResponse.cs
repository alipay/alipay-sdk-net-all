using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentCreateandpayResponse.
    /// </summary>
    public class AlipayCommerceMedicalPaymentCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 国家医保局线上业务下单信息
        /// </summary>
        [XmlElement("data")]
        public MedicalOnlineCreateAndPayInfo Data { get; set; }

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
