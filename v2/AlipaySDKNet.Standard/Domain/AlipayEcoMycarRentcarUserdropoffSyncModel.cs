using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarUserdropoffSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarUserdropoffSyncModel : AopObject
    {
        /// <summary>
        /// 实际还车时间
        /// </summary>
        [XmlElement("actual_drop_off_time")]
        public string ActualDropOffTime { get; set; }

        /// <summary>
        /// 行驶距离，单位公里
        /// </summary>
        [XmlElement("driving_distance")]
        public long DrivingDistance { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
