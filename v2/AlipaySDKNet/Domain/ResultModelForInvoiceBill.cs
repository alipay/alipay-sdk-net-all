using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResultModelForInvoiceBill Data Structure.
    /// </summary>
    [Serializable]
    public class ResultModelForInvoiceBill : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误详细信息，一般用于方便定位，业务不用care
        /// </summary>
        [XmlElement("error_detail_info")]
        public string ErrorDetailInfo { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
