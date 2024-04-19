using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIpsponsorConsumegoldQueryResponse.
    /// </summary>
    public class AlipayOpenIpsponsorConsumegoldQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通状态 0:未开通; 1:开通
        /// </summary>
        [XmlElement("open_status")]
        public string OpenStatus { get; set; }

        /// <summary>
        /// 用户拥有的总消费金
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
