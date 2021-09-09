using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 客户端时间
        /// </summary>
        [XmlElement("app_time_stamp")]
        public string AppTimeStamp { get; set; }

        /// <summary>
        /// 返回结果编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 返回结果描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 服务段时间
        /// </summary>
        [XmlElement("server_time_stamp")]
        public string ServerTimeStamp { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子状态
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }
    }
}
