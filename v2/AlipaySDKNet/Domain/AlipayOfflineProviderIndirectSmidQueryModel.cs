using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderIndirectSmidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderIndirectSmidQueryModel : AopObject
    {
        /// <summary>
        /// 码值
        /// </summary>
        [XmlElement("origin_qrvalue")]
        public string OriginQrvalue { get; set; }
    }
}
