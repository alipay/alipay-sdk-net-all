using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationTradedataBatchqueryResponse.
    /// </summary>
    public class AlipayBusinessRelationTradedataBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈经营数据信息
        /// </summary>
        [XmlElement("mall_trade_data_info")]
        public BusinessRelationTradeInfo MallTradeDataInfo { get; set; }

        /// <summary>
        /// 门店经营数据信息列表
        /// </summary>
        [XmlArray("shop_trade_data_infos")]
        [XmlArrayItem("business_relation_shop_trade_info")]
        public List<BusinessRelationShopTradeInfo> ShopTradeDataInfos { get; set; }

        /// <summary>
        /// 门店总数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
