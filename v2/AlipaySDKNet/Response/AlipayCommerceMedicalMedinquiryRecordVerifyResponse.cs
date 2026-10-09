using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedinquiryRecordVerifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedinquiryRecordVerifyResponse : AopResponse
    {
        /// <summary>
        /// 返回是否存在预问诊病例
        /// </summary>
        [XmlElement("data")]
        public InquiryBizContent Data { get; set; }

        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }
    }
}
