using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderDeviceTradeQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderDeviceTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 累计有效交易笔数
        /// </summary>
        [XmlElement("alipay_trade_count")]
        public string AlipayTradeCount { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 间联商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 累计有效碰交易笔数区间
        /// </summary>
        [XmlElement("touch_trade_count_range")]
        public string TouchTradeCountRange { get; set; }
    }
}
