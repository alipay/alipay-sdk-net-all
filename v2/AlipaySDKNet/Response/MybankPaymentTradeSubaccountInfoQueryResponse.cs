using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeSubaccountInfoQueryResponse.
    /// </summary>
    public class MybankPaymentTradeSubaccountInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 开子户请求的外部渠道ID
        /// </summary>
        [XmlElement("out_channel_id")]
        public string OutChannelId { get; set; }

        /// <summary>
        /// 开通子户的外部请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 子户外标
        /// </summary>
        [XmlElement("sub_card_no")]
        public string SubCardNo { get; set; }
    }
}
