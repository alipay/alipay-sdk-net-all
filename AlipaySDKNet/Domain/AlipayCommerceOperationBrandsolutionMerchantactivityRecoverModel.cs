using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBrandsolutionMerchantactivityRecoverModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBrandsolutionMerchantactivityRecoverModel : AopObject
    {
        /// <summary>
        /// 活动唯一标识
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户pid，唯一标识，允许批量修改，单次最大10条
        /// </summary>
        [XmlArray("merchant_ids")]
        [XmlArrayItem("string")]
        public List<string> MerchantIds { get; set; }
    }
}
