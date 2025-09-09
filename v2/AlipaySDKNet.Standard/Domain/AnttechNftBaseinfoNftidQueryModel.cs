using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftBaseinfoNftidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftBaseinfoNftidQueryModel : AopObject
    {
        /// <summary>
        /// 资产唯一编码
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }
    }
}
