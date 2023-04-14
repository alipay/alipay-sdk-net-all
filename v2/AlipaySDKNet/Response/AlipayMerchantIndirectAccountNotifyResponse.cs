using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectAccountNotifyResponse.
    /// </summary>
    public class AlipayMerchantIndirectAccountNotifyResponse : AopResponse
    {
        /// <summary>
        /// 交易响应码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 响应码信息
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }

        /// <summary>
        /// 交易响应状态 FA:失败SU:成功
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
