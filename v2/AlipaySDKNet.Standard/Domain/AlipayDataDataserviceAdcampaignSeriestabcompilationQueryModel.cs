using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignSeriestabcompilationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignSeriestabcompilationQueryModel : AopObject
    {
        /// <summary>
        /// 营销目标编码,缺失透传 null
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 商家标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 生活号 ID,空→INVALID_PARAMETER(publicId 不能为空)
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
