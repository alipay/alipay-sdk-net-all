using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillIstddetailQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillIstddetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 预计还剩多久送达 单位：秒
        /// </summary>
        [XmlElement("reach_duration")]
        public long ReachDuration { get; set; }

        /// <summary>
        /// 骑手位置纬度
        /// </summary>
        [XmlElement("rider_lat")]
        public long RiderLat { get; set; }

        /// <summary>
        /// 骑手位置经度
        /// </summary>
        [XmlElement("rider_lng")]
        public long RiderLng { get; set; }

        /// <summary>
        /// 骑手电话
        /// </summary>
        [XmlElement("rider_mobile_no")]
        public string RiderMobileNo { get; set; }

        /// <summary>
        /// 骑手姓名
        /// </summary>
        [XmlElement("rider_name")]
        public string RiderName { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
