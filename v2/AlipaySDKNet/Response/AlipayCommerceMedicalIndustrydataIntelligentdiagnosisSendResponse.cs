using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataIntelligentdiagnosisSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataIntelligentdiagnosisSendResponse : AopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("chat_content")]
        public MedicalGuideChatContentDTO ChatContent { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }
    }
}
