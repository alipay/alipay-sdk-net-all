using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersaleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderAftersaleQueryResponse : AopResponse
    {
        /// <summary>
        /// 售后单触发类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("aftersale_goods_info_list")]
        [XmlArrayItem("aftersale_item_info")]
        public List<AftersaleItemInfo> AftersaleGoodsInfoList { get; set; }

        /// <summary>
        /// 平台售后单号
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 用户售后发起原因
        /// </summary>
        [XmlElement("aftersale_reason")]
        public string AftersaleReason { get; set; }

        /// <summary>
        /// 物流单详情
        /// </summary>
        [XmlArray("logistics_waybills")]
        [XmlArrayItem("logistics_waybill")]
        public List<LogisticsWaybill> LogisticsWaybills { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 商家小程序售后单页面
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 售后单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 售后单状态code
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
