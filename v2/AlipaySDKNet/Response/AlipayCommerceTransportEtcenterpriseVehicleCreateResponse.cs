using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseVehicleCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseVehicleCreateResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS：订单申请成功； FAIL:申请失败原因
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 其他业务异常信息描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 支付宝车辆id
        /// </summary>
        [XmlElement("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
