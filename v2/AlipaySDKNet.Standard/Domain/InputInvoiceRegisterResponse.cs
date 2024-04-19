using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceRegisterResponse Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceRegisterResponse : AopObject
    {
        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("data")]
        public long Data { get; set; }

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
