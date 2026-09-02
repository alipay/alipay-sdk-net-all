using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseChannelRateQueryResponse.
    /// </summary>
    public class AnttechOceanbaseChannelRateQueryResponse : AopResponse
    {
        /// <summary>
        /// 抽佣比例，单位：%
        /// </summary>
        [XmlElement("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 渠道code
        /// </summary>
        [XmlElement("sell_channel_code")]
        public string SellChannelCode { get; set; }

        /// <summary>
        /// 分成比例，单位：%
        /// </summary>
        [XmlElement("split_rate")]
        public string SplitRate { get; set; }
    }
}
