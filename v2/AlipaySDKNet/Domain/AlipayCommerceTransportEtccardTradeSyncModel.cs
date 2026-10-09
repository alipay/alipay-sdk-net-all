using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtccardTradeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtccardTradeSyncModel : AopObject
    {
        /// <summary>
        /// ETC卡编号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 入口收费站id（GID编码）
        /// </summary>
        [XmlElement("en_station_id")]
        public string EnStationId { get; set; }

        /// <summary>
        /// 入口收费站名称
        /// </summary>
        [XmlElement("en_station_name")]
        public string EnStationName { get; set; }

        /// <summary>
        /// 入口时间
        /// </summary>
        [XmlElement("en_time")]
        public string EnTime { get; set; }

        /// <summary>
        /// 出口收费站id（GID编码）
        /// </summary>
        [XmlElement("ex_station_id")]
        public string ExStationId { get; set; }

        /// <summary>
        /// 出口收费站名称
        /// </summary>
        [XmlElement("ex_station_name")]
        public string ExStationName { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("ex_time")]
        public string ExTime { get; set; }

        /// <summary>
        /// 交易金额,单位元
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

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
        /// 通行省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 通行省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 通行记录唯一标识
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
