using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChinaMobileHead Data Structure.
    /// </summary>
    [Serializable]
    public class ChinaMobileHead : AopObject
    {
        /// <summary>
        /// 移动标志请求apiId
        /// </summary>
        [XmlElement("api_id")]
        public string ApiId { get; set; }

        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 移动签名字段sign为支付宝标准字段,改为使用china_mobile_sign传递
        /// </summary>
        [XmlElement("china_mobile_sign")]
        public string ChinaMobileSign { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("china_mobile_version")]
        public string ChinaMobileVersion { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("req_time")]
        public string ReqTime { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
