using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 抬头Id
        /// </summary>
        [XmlElement("title_id")]
        public string TitleId { get; set; }
    }
}
