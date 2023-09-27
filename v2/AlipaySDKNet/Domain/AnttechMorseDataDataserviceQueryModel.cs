using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseDataDataserviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseDataDataserviceQueryModel : AopObject
    {
        /// <summary>
        /// 由摩斯同学配置并分配给调用方的服务对应标识号
        /// </summary>
        [XmlElement("consult_id")]
        public string ConsultId { get; set; }

        /// <summary>
        /// mobile_sha256标识用户唯一信息，通过用户手机号SHA256 哈希后获得
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }
    }
}
