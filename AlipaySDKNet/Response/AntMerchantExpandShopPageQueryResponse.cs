using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopPageQueryResponse.
    /// </summary>
    public class AntMerchantExpandShopPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店详情
        /// </summary>
        [XmlArray("shop_infos")]
        [XmlArrayItem("shop_query_open_api_v_o")]
        public List<ShopQueryOpenApiVO> ShopInfos { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
