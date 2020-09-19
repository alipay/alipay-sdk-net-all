using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceTradeInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceTradeInfoList : AopObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// DAU
        /// </summary>
        [XmlElement("dau")]
        public long Dau { get; set; }

        /// <summary>
        /// 刷脸DAU
        /// </summary>
        [XmlElement("device_face_trade_dau")]
        public long DeviceFaceTradeDau { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备激活状态
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 扫脸交易笔数
        /// </summary>
        [XmlElement("face_trade_cnt")]
        public long FaceTradeCnt { get; set; }

        /// <summary>
        /// 激活时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        [XmlElement("max_dt")]
        public string MaxDt { get; set; }

        /// <summary>
        /// 商家pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("trade_amt")]
        public string TradeAmt { get; set; }

        /// <summary>
        /// 交易笔数
        /// </summary>
        [XmlElement("trade_cnt")]
        public long TradeCnt { get; set; }
    }
}
