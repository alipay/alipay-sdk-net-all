using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TenantListNftDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TenantListNftDTO : AopObject
    {
        /// <summary>
        /// 藏品上架金额(单位：分)
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 藏品NFTID
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }
    }
}
