using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceFundBindCreateResponse.
    /// </summary>
    public class AlipayCommerceFundBindCreateResponse : AopResponse
    {
        /// <summary>
        /// 本此绑卡操作是否幂等。true表示该out_bind_no已经生成过schema，此时会返回上次已生成的schema
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }

        /// <summary>
        /// 绑卡流水号，用来标识一次绑卡行为，商户维度下需确保唯一
        /// </summary>
        [XmlElement("out_bind_no")]
        public string OutBindNo { get; set; }

        /// <summary>
        /// 基金绑卡的跳转地址
        /// </summary>
        [XmlElement("schema")]
        public string Schema { get; set; }
    }
}
