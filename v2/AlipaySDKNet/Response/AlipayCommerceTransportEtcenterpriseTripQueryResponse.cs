using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseTripQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseTripQueryResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS：订单申请成功； FAIL:申请失败
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 其他业务异常信息描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 行程单据列表
        /// </summary>
        [XmlArray("trip_list")]
        [XmlArrayItem("etc_trip_info")]
        public List<EtcTripInfo> TripList { get; set; }
    }
}
