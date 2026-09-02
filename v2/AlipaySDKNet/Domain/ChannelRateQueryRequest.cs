using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelRateQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelRateQueryRequest : AopObject
    {
        /// <summary>
        /// 账期，格式yyyy-MM
        /// </summary>
        [XmlElement("bill_period")]
        public string BillPeriod { get; set; }

        /// <summary>
        /// 渠道code，可使用anttech.oceanbase.channel.list.query接口查询多有的渠道code
        /// </summary>
        [XmlElement("sell_channel_code")]
        public string SellChannelCode { get; set; }
    }
}
