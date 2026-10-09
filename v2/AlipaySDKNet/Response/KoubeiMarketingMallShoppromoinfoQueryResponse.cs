using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingMallShoppromoinfoQueryResponse.
    /// </summary>
    public class KoubeiMarketingMallShoppromoinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 店铺营销信息详情
        /// </summary>
        [XmlArray("shop_promo_infos")]
        [XmlArrayItem("shop_promo_info")]
        public List<ShopPromoInfo> ShopPromoInfos { get; set; }
    }
}
