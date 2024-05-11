using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcShoppoolShopQueryResponse.
    /// </summary>
    public class AlipayCommerceEcShoppoolShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 搜索后的门店信息列表
        /// </summary>
        [XmlArray("shop_info_list")]
        [XmlArrayItem("ec_shop_detail")]
        public List<EcShopDetail> ShopInfoList { get; set; }
    }
}
