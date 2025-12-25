using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmEquityorderstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmEquityorderstatusSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("appoint_info_list")]
        [XmlArrayItem("hm_appoint_info")]
        public List<HmAppointInfo> AppointInfoList { get; set; }

        /// <summary>
        /// 健管用户uid
        /// </summary>
        [XmlElement("hm_uid")]
        public string HmUid { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 要修改的订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
