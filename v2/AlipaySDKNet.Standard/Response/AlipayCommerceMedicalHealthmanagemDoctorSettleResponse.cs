using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthmanagemDoctorSettleResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthmanagemDoctorSettleResponse : AopResponse
    {
        /// <summary>
        /// 医生核算结果
        /// </summary>
        [XmlElement("data")]
        public DoctorAccountingResponse Data { get; set; }
    }
}
