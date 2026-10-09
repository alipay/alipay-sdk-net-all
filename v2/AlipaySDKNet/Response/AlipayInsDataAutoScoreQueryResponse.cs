using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsDataAutoScoreQueryResponse.
    /// </summary>
    public class AlipayInsDataAutoScoreQueryResponse : AopResponse
    {
        /// <summary>
        /// 唯一流水号，调用方应持久化本字段
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 专属分分值，浮点数
        /// </summary>
        [XmlElement("exclusive_score")]
        public string ExclusiveScore { get; set; }

        /// <summary>
        /// 扩展信息，标准JSON格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 车险分
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 请求发起时通过程序生成并传递UUID，调用方应持久化本字段
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
