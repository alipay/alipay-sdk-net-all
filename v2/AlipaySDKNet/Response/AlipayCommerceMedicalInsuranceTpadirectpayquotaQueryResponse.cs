using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpadirectpayquotaQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceTpadirectpayquotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 基金额度（单位：元）保留两位小数
        /// </summary>
        [XmlElement("quota")]
        public string Quota { get; set; }
    }
}
