using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverauthstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverauthstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 司机认证状态
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 合作方司机id
        /// </summary>
        [XmlElement("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// 司机支付宝uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 是否开通收钱码
        /// </summary>
        [XmlElement("qrcode_flag")]
        public string QrcodeFlag { get; set; }
    }
}
