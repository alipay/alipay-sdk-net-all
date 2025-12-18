using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardExpiretimeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardExpiretimeModifyModel : AopObject
    {
        /// <summary>
        /// 安心付卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 延期后的过期时间
        /// </summary>
        [XmlElement("expand_expire_time")]
        public string ExpandExpireTime { get; set; }

        /// <summary>
        /// 延期原因
        /// </summary>
        [XmlElement("expand_reason")]
        public string ExpandReason { get; set; }
    }
}
