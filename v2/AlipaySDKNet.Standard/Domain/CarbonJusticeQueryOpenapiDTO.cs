using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarbonJusticeQueryOpenapiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CarbonJusticeQueryOpenapiDTO : AopObject
    {
        /// <summary>
        /// 本次绿色行程的距离。单位-米。目前仅地铁支持距离计算
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 该绿色行程是什么类型
        /// </summary>
        [XmlElement("trip_type")]
        public string TripType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
