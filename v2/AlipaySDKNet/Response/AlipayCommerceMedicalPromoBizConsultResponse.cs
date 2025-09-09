using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPromoBizConsultResponse.
    /// </summary>
    public class AlipayCommerceMedicalPromoBizConsultResponse : AopResponse
    {
        /// <summary>
        /// 业务处理码
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
