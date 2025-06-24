using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBenefitPurchaseCheckResponse.
    /// </summary>
    public class AlipayCommerceMedicalBenefitPurchaseCheckResponse : AopResponse
    {
        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("res_code")]
        public string ResCode { get; set; }

        /// <summary>
        /// true：校验通过，false：校验失败
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
