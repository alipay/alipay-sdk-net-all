using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquirydoctorstatusUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataInquirydoctorstatusUploadResponse : AopResponse
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
