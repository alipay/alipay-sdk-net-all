using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardConsumelistQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardConsumelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 次卡信息
        /// </summary>
        [XmlElement("card_info")]
        public TimeCardConsumeCardInfo CardInfo { get; set; }

        /// <summary>
        /// 次卡消费记录列表
        /// </summary>
        [XmlArray("consume_record")]
        [XmlArrayItem("time_card_consumer_record_info")]
        public List<TimeCardConsumerRecordInfo> ConsumeRecord { get; set; }
    }
}
