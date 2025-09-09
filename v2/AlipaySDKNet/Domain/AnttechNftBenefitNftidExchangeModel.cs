using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftBenefitNftidExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftBenefitNftidExchangeModel : AopObject
    {
        /// <summary>
        /// nftId藏品的账号id
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 请求幂等id
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
