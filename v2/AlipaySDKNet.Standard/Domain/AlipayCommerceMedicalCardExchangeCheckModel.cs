using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardExchangeCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardExchangeCheckModel : AopObject
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
