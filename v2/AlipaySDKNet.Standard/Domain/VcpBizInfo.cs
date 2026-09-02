using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpBizInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VcpBizInfo : AopObject
    {
        /// <summary>
        /// 业务标签
        /// </summary>
        [XmlArray("biz_tags")]
        [XmlArrayItem("string")]
        public List<string> BizTags { get; set; }

        /// <summary>
        /// 营销内容
        /// </summary>
        [XmlElement("promo_target")]
        public VcpPromoTargetInfo PromoTarget { get; set; }
    }
}
