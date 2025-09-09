using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDoctorcontentdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataDoctorcontentdetailQueryResponse : AopResponse
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
        /// 无
        /// </summary>
        [XmlElement("statistical_result")]
        public DoctorContentStatisticalResult StatisticalResult { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
