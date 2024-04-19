using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupEntryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupEntryQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 集团入驻单号
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }
    }
}
