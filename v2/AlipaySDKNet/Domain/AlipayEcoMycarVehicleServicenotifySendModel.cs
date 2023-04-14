using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleServicenotifySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarVehicleServicenotifySendModel : AopObject
    {
        /// <summary>
        /// 商户业务响应码
        /// </summary>
        [XmlElement("merchant_status_code")]
        public string MerchantStatusCode { get; set; }

        /// <summary>
        /// 商户响应码描述
        /// </summary>
        [XmlElement("merchant_status_desc")]
        public string MerchantStatusDesc { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 服务操作的业务时间戳
        /// </summary>
        [XmlElement("service_operate_timestamp")]
        public string ServiceOperateTimestamp { get; set; }

        /// <summary>
        /// 服务状态
        /// </summary>
        [XmlElement("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 当前系统时间戳
        /// </summary>
        [XmlElement("system_timestamp")]
        public string SystemTimestamp { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车企openid
        /// </summary>
        [XmlElement("vehicle_open_id")]
        public string VehicleOpenId { get; set; }

        /// <summary>
        /// 车企token
        /// </summary>
        [XmlElement("vehicle_token")]
        public VehicleToken VehicleToken { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }
    }
}
