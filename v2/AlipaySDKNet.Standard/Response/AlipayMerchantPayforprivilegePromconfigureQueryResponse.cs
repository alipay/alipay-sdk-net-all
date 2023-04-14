using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromconfigureQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromconfigureQueryResponse : AopResponse
    {
        /// <summary>
        /// 可核销的店铺id列表
        /// </summary>
        [XmlArray("enabled_shop_list")]
        [XmlArrayItem("string")]
        public List<string> EnabledShopList { get; set; }

        /// <summary>
        /// 剔除的单品id 列表
        /// </summary>
        [XmlArray("exclude_item_ids")]
        [XmlArrayItem("string")]
        public List<string> ExcludeItemIds { get; set; }

        /// <summary>
        /// 支持核销的商品id
        /// </summary>
        [XmlArray("support_item_ids")]
        [XmlArrayItem("string")]
        public List<string> SupportItemIds { get; set; }
    }
}
