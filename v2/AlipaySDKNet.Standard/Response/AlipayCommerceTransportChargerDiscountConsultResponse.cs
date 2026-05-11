using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerDiscountConsultResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerDiscountConsultResponse : AopResponse
    {
        /// <summary>
        /// 活动优惠信息
        /// </summary>
        [XmlElement("activity_info")]
        public ChargerDiscountActivityInfo ActivityInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("activity_quota")]
        [XmlArrayItem("charger_discount_activity_quota")]
        public List<ChargerDiscountActivityQuota> ActivityQuota { get; set; }

        /// <summary>
        /// 业务时间，格式：yyyy-MM-dd HH:mm: ss
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }
    }
}
