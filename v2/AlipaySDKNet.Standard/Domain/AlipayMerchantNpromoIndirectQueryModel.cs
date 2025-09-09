using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantNpromoIndirectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantNpromoIndirectQueryModel : AopObject
    {
        /// <summary>
        /// 当前登录用户对应的服务商商户号，可能有多个
        /// </summary>
        [XmlArray("merchant_brief_list")]
        [XmlArrayItem("merchant_brief_info")]
        public List<MerchantBriefInfo> MerchantBriefList { get; set; }
    }
}
