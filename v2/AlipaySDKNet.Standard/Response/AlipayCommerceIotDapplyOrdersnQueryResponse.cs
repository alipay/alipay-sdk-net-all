using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrdersnQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrdersnQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备申请业务订单号，接口传入原样返回
        /// </summary>
        [XmlElement("order_biz_id")]
        public string OrderBizId { get; set; }

        /// <summary>
        /// 订单发货的设备SN
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }
    }
}
