using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderItembillBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderItembillBatchqueryModel : AopObject
    {
        /// <summary>
        /// 订单创建日期，格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 订单状态，传入此参数可查询指定状态的订单
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 账单类型分类列表
        /// </summary>
        [XmlArray("service_type_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceTypeList { get; set; }

        /// <summary>
        /// 结算状态，传入此参数可查询指定结算状态的订单
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 订单结算日期，格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("settlement_date")]
        public string SettlementDate { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
