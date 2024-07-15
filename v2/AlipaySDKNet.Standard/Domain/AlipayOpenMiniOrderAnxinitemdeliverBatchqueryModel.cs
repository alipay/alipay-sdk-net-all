using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderAnxinitemdeliverBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderAnxinitemdeliverBatchqueryModel : AopObject
    {
        /// <summary>
        /// 安心付金额卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，单位：条目数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 安心付金额卡每笔使用状态，不填默认查询所有。枚举包括： 已使用 已退款
        /// </summary>
        [XmlArray("use_status")]
        [XmlArrayItem("string")]
        public List<string> UseStatus { get; set; }

        /// <summary>
        /// 安心付金额卡每笔使用时间，格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("use_time")]
        public string UseTime { get; set; }
    }
}
