using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppAccountBalanceQueryResponse.
    /// </summary>
    public class AlipayEbppAccountBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构子账号编码
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 可用余额，单位分
        /// </summary>
        [XmlElement("available_money")]
        public string AvailableMoney { get; set; }

        /// <summary>
        /// 总余额，单位分
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 余额对应的事件 YYYYMMDD
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 冻结 余额单位分
        /// </summary>
        [XmlElement("freeze_money")]
        public string FreezeMoney { get; set; }

        /// <summary>
        /// YYYYMMDDHHmmss，精确到秒的请求事件，代表请求账务返回数据时的时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
