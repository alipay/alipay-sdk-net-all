using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverinfoModifyModel : AopObject
    {
        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 司机和车辆信息
        /// </summary>
        [XmlElement("driver_car_info")]
        public DriverCarInfo DriverCarInfo { get; set; }

        /// <summary>
        /// 司机open_id
        /// </summary>
        [XmlElement("driver_open_id")]
        public string DriverOpenId { get; set; }

        /// <summary>
        /// 司机uid
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
