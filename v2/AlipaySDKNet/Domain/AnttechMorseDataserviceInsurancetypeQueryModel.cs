using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseDataserviceInsurancetypeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseDataserviceInsurancetypeQueryModel : AopObject
    {
        /// <summary>
        /// id_card_sha256标识用户唯一信息，通过用户身份证号SHA256 哈希后获得
        /// </summary>
        [XmlElement("id_card_sha_256")]
        public string IdCardSha256 { get; set; }
    }
}
