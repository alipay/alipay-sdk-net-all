using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderCreateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainBizorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务订单编号，规则28位；
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
