using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppRechargeItemGetResponse.
    /// </summary>
    public class AlipayEbppRechargeItemGetResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 系统返回错误码
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 充值面额状态对象list
        /// </summary>
        [XmlArray("iterm_infos")]
        [XmlArrayItem("iterm_info")]
        public List<ItermInfo> ItermInfos { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
