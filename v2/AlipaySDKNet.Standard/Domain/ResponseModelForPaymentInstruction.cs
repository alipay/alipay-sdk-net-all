using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResponseModelForPaymentInstruction Data Structure.
    /// </summary>
    [Serializable]
    public class ResponseModelForPaymentInstruction : AopObject
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("cash_summary_d_t_o")]
        public List<CashSummaryDTO> Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误详细信息
        /// </summary>
        [XmlElement("error_detail_info")]
        public string ErrorDetailInfo { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
