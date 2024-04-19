using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupEntryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupEntryCreateModel : AopObject
    {
        /// <summary>
        /// 集团入驻单号
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 有无营业执照
        /// </summary>
        [XmlElement("have_business")]
        public bool HaveBusiness { get; set; }

        /// <summary>
        /// 集团入驻成功后，期望跳转的地址
        /// </summary>
        [XmlElement("jump_link")]
        public string JumpLink { get; set; }
    }
}
