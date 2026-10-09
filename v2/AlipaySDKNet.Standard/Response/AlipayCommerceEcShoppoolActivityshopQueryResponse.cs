using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcShoppoolActivityshopQueryResponse.
    /// </summary>
    public class AlipayCommerceEcShoppoolActivityshopQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店列表信息
        /// </summary>
        [XmlArray("shop_info_list")]
        [XmlArrayItem("ec_shop_detail")]
        public List<EcShopDetail> ShopInfoList { get; set; }

        /// <summary>
        /// 门店总个数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
