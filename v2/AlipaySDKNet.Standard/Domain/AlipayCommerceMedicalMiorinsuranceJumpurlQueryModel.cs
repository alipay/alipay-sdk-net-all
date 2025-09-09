using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMiorinsuranceJumpurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMiorinsuranceJumpurlQueryModel : AopObject
    {
        /// <summary>
        /// 商品的医保编码
        /// </summary>
        [XmlElement("insurance_code")]
        public string InsuranceCode { get; set; }

        /// <summary>
        /// 医保国标编码
        /// </summary>
        [XmlElement("mi_code")]
        public string MiCode { get; set; }

        /// <summary>
        /// 渠道（区分渠道兼容后续多平台、对于这种模式默认要打公域标）
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
