using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeFinanceAdvanceApplyResponse.
    /// </summary>
    public class AlipayTradeFinanceAdvanceApplyResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段用于返回资金机构（例如保司等）的单号
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 处理结果，如果是ACCEPT_SUCCESS，表示系统受理成功 异步处理中，需要接入垫资结果通知消息
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
