using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffInventoryrealtimeSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffInventoryrealtimeSyncResponse : AopResponse
    {
        /// <summary>
        /// 报错码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 报错描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
