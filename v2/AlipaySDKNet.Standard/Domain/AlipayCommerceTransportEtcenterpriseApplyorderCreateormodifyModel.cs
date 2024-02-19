using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseApplyorderCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseApplyorderCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 办理人所在地城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 企业订单对应支付宝企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 车辆发动机号码
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// ETC办理激活手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 审核资料提交状态。WAIT_SUBMIT：信息待提交；SUBMITTED：信息已提交。
        /// </summary>
        [XmlElement("order_censor_status")]
        public string OrderCensorStatus { get; set; }

        /// <summary>
        /// 支付宝订单号，提供则认为是更新
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 办理车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 发行方的标识ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 车辆识别号
        /// </summary>
        [XmlElement("vi_vin")]
        public string ViVin { get; set; }
    }
}
