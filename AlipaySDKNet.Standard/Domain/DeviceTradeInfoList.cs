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
        /// 当日刷脸付用户数-同比差值
        /// </summary>
        [XmlElement("device_face_trade_dau_d_value")]
        public long DeviceFaceTradeDauDValue { get; set; }

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
        /// 当日刷脸付笔数占比
        /// </summary>
        [XmlElement("face_trd_cnt_rate")]
        public string FaceTrdCntRate { get; set; }

        /// <summary>
        /// 当日刷脸付用户数占比
        /// </summary>
        [XmlElement("face_trd_user_cnt_rate")]
        public string FaceTrdUserCntRate { get; set; }

        /// <summary>
        /// 当日刷脸付用户数占比-同比差值
        /// </summary>
        [XmlElement("face_trd_user_cnt_rate_d_value")]
        public string FaceTrdUserCntRateDValue { get; set; }

        /// <summary>
        /// 激活时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 当日支付宝客单价(元)
        /// </summary>
        [XmlElement("iot_trd_up")]
        public string IotTrdUp { get; set; }

        /// <summary>
        /// 当日支付宝交易用户数
        /// </summary>
        [XmlElement("iot_trd_user_cnt")]
        public long IotTrdUserCnt { get; set; }

        /// <summary>
        /// 当日支付宝交易用户数-同比差值
        /// </summary>
        [XmlElement("iot_trd_user_cnt_d_value")]
        public long IotTrdUserCntDValue { get; set; }

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
