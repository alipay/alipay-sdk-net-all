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
        public string RiderLat { get; set; }

        /// <summary>
        /// 骑手位置经度
        /// </summary>
        [XmlElement("rider_lng")]
        public string RiderLng { get; set; }

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
        /// 骑手实时定位H5链接字段，在骑手已接单后，将可展示骑手实时位置的H5页面链接同步商户
        /// </summary>
        [XmlElement("rider_poi_link")]
        public string RiderPoiLink { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
