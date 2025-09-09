using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBenefitPointPayResponse.
    /// </summary>
    public class AlipayCommerceMedicalBenefitPointPayResponse : AopResponse
    {
        /// <summary>
        /// 处理码
        /// </summary>
        [XmlElement("res_code")]
        public string ResCode { get; set; }

        /// <summary>
        /// 业务处理标识
        /// </summary>
        [XmlElement("res_flag")]
        public bool ResFlag { get; set; }

        /// <summary>
        /// 业务处理描述
        /// </summary>
        [XmlElement("res_msg")]
        public string ResMsg { get; set; }
    }
}
