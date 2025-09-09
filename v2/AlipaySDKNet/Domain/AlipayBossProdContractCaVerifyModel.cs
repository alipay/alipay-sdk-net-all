using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractCaVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractCaVerifyModel : AopObject
    {
        /// <summary>
        /// http地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
