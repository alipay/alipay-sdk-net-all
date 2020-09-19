using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceOrderInfoModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceOrderInfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 明细返回码
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 明细返回码描述
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }
    }
}
