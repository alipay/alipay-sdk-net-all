using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayTripCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportExpresswayTripCreateandpayModel : AopObject
    {
        /// <summary>
        /// 支付宝侧车牌付代扣协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 1、收费站出口名称 2、格式为省份+收费站名，比如“黑龙江瓦盆窑西站”
        /// </summary>
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 收费站出口名称编码
        /// </summary>
        [XmlElement("end_station_name_code")]
        public string EndStationNameCode { get; set; }

        /// <summary>
        /// 1、该字段为高速出口的时间 2、其他对应路网规范中的chargeTime字段
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 调用方标识ID
        /// </summary>
        [XmlElement("isv_id")]
        public string IsvId { get; set; }

        /// <summary>
        /// 行程描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 路网侧扣款行程单号： 1、需要与真实的扣款行程对应 2、路网侧全国车牌付场景下唯一
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

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
        /// 若超过账期，请传递补扣标识为true，本批次行程受理将不限制账期。 默认false；
        /// </summary>
        [XmlElement("replenish_deduct")]
        public bool ReplenishDeduct { get; set; }

        /// <summary>
        /// 收款方pid
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 1、收费站入口名称 2、格式为省份+收费站名，比如“黑龙江瓦盆窑西站”
        /// </summary>
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 收费站入口名称编码
        /// </summary>
        [XmlElement("start_station_name_code")]
        public string StartStationNameCode { get; set; }

        /// <summary>
        /// 进站时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 行程标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 行程需扣费金额，单位人民币元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
