using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductInvoiceCheckResult Data Structure.
    /// </summary>
    [Serializable]
    public class ProductInvoiceCheckResult : AopObject
    {
        /// <summary>
        /// 企业信息校验的校验项编码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 异常校验项的校验时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 企业信息校验的校验异常编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 企业信息异常校验的信息提示
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
