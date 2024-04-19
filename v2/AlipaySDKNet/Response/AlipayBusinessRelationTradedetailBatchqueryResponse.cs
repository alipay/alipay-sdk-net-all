using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationTradedetailBatchqueryResponse.
    /// </summary>
    public class AlipayBusinessRelationTradedetailBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 物理门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [XmlElement("real_shop_no")]
        public string RealShopNo { get; set; }

        /// <summary>
        /// 门店确权状态，READY、PENDING两种状态
        /// </summary>
        [XmlElement("shop_confirm_status")]
        public string ShopConfirmStatus { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店交易数据详细信息列表
        /// </summary>
        [XmlArray("shop_trade_data_detail_infos")]
        [XmlArrayItem("business_relation_shop_trade_detail_info")]
        public List<BusinessRelationShopTradeDetailInfo> ShopTradeDataDetailInfos { get; set; }

        /// <summary>
        /// 门店总数
        /// </summary>
        [XmlElement("total_num")]
        public string TotalNum { get; set; }
    }
}
