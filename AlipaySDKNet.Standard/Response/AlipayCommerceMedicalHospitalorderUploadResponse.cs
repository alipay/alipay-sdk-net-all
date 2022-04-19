using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHospitalorderUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalHospitalorderUploadResponse : AopResponse
    {
        /// <summary>
        /// 医疗机构医院订单上传结果
        /// </summary>
        [XmlElement("data")]
        public MedicalHospitalOrderUploadResult Data { get; set; }

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
