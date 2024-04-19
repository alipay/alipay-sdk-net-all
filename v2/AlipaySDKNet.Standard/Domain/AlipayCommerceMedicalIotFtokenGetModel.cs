using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIotFtokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIotFtokenGetModel : AopObject
    {
        /// <summary>
        /// 用户医保码值
        /// </summary>
        [XmlElement("medical_code")]
        public string MedicalCode { get; set; }
    }
}
