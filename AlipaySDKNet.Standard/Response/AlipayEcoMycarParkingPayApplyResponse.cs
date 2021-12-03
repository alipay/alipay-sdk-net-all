using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingPayApplyResponse.
    /// </summary>
    public class AlipayEcoMycarParkingPayApplyResponse : AopResponse
    {
        /// <summary>
        /// 业务返回码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务返回码描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 支付宝停车平台订单号
        /// </summary>
        [XmlElement("parking_order_no")]
        public string ParkingOrderNo { get; set; }
    }
}
