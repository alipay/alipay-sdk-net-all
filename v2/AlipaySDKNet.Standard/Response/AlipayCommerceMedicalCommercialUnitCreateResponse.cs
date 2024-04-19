using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialUnitCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialUnitCreateResponse : AopResponse
    {
        /// <summary>
        /// 医疗生成的门店编码
        /// </summary>
        [XmlElement("unit_code")]
        public string UnitCode { get; set; }
    }
}
