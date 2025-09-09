using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceFundTransferDetectResponse.
    /// </summary>
    public class AlipayCommerceFundTransferDetectResponse : AopResponse
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        [XmlElement("data_code")]
        public long DataCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("data_message")]
        public string DataMessage { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data_result")]
        public string DataResult { get; set; }

        /// <summary>
        /// 银行核对结果
        /// </summary>
        [XmlElement("data_success")]
        public bool DataSuccess { get; set; }

        /// <summary>
        /// 交易发生的时间戳
        /// </summary>
        [XmlElement("data_timestamp")]
        public long DataTimestamp { get; set; }
    }
}
