using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalPaymentQueryResponse : AopResponse
    {
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

        /// <summary>
        /// 医保支付订单查询信息
        /// </summary>
        [XmlElement("result_data")]
        public MedicalPaymentQueryResponse ResultData { get; set; }
    }
}
