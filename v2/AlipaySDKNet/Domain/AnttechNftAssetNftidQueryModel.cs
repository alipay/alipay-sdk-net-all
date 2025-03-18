using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftAssetNftidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftAssetNftidQueryModel : AopObject
    {
        /// <summary>
        /// 用户账户
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 资产唯一编码
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }
    }
}
