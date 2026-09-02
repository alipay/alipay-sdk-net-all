using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelUserRateQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelUserRateQueryRequest : AopObject
    {
        /// <summary>
        /// 账期，格式yyyy-MM
        /// </summary>
        [XmlElement("bill_period")]
        public string BillPeriod { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 渠道code，可使用anttech.oceanbase.channel.list.query接口查询多有的渠道code
        /// </summary>
        [XmlElement("sell_channel_code")]
        public string SellChannelCode { get; set; }
    }
}
