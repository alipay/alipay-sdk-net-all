using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceResponse Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceResponse : AopObject
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("response_msg")]
        public string ResponseMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succeeded")]
        public bool Succeeded { get; set; }
    }
}
