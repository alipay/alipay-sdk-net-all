using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceHkmedicalSigninModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceHkmedicalSigninModel : AopObject
    {
        /// <summary>
        /// 医院 id
        /// </summary>
        [XmlElement("hosp_id")]
        public string HospId { get; set; }

        /// <summary>
        /// 商保码二维码串
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }
    }
}
