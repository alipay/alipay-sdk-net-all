using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainTwcTradeinfoQueryResponse.
    /// </summary>
    public class AnttechBlockchainTwcTradeinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单核验的结果说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 是否与订单的信息一致
        /// </summary>
        [XmlElement("match")]
        public bool Match { get; set; }

        /// <summary>
        /// 订单核验的结果状态码
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
