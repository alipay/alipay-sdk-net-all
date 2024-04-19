using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainTwcPreauthinfoQueryResponse.
    /// </summary>
    public class AnttechBlockchainTwcPreauthinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单信息若不一致，错误信息状态描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 是否核验通过
        /// </summary>
        [XmlElement("match")]
        public bool Match { get; set; }

        /// <summary>
        /// 订单信息是否匹配
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
