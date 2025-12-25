using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcCorpInvoiceTrade Data Structure.
    /// </summary>
    [Serializable]
    public class EtcCorpInvoiceTrade : AopObject
    {
        /// <summary>
        /// 虚拟运单编码
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 行云卡号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 运单结束地址
        /// </summary>
        [XmlElement("end_address")]
        public string EndAddress { get; set; }

        /// <summary>
        /// 运单结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 高速费用,单位分
        /// </summary>
        [XmlElement("highway_fee")]
        public long HighwayFee { get; set; }

        /// <summary>
        /// 开票状态
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 运单开始地址
        /// </summary>
        [XmlElement("start_address")]
        public string StartAddress { get; set; }

        /// <summary>
        /// 运单开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交易信息列表
        /// </summary>
        [XmlArray("trade_list")]
        [XmlArrayItem("etc_inovice_trade_list")]
        public List<EtcInoviceTradeList> TradeList { get; set; }

        /// <summary>
        /// 运单费用,单位分
        /// </summary>
        [XmlElement("waybill_fee")]
        public long WaybillFee { get; set; }

        /// <summary>
        /// 外部企业运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
