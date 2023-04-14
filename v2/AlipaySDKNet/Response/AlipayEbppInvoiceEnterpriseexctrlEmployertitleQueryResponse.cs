using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 企业抬头信息
        /// </summary>
        [XmlElement("title_info")]
        public EnterpriseTitleInfo TitleInfo { get; set; }
    }
}
