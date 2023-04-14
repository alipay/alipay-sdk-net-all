using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserBillDetailQueryResponse.
    /// </summary>
    public class AlipayUserBillDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 消费记录模型
        /// </summary>
        [XmlElement("consume_record")]
        public ConsumeRecord ConsumeRecord { get; set; }
    }
}
