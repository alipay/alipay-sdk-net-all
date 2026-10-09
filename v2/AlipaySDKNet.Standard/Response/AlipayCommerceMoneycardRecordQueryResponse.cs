using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMoneycardRecordQueryResponse.
    /// </summary>
    public class AlipayCommerceMoneycardRecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 金额卡核销订单详情
        /// </summary>
        [XmlElement("money_card_use_record_detail")]
        public MoneyCardUseRecordDetail MoneyCardUseRecordDetail { get; set; }
    }
}
