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
        /// 门店地址库 ID，按照一定的平台规则识别出的线下真实存在、真实经营的蚂蚁门店地址库 ID，将作用于服务商的返佣激励、商品/券等权益的公域分发。如平台未返回alipay_poiid，请在确认门店信息真实有效后，稍后再进行查询
        /// </summary>
        [XmlElement("alipay_poiid")]
        public string AlipayPoiid { get; set; }

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
