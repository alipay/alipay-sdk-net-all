using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SingleResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SingleResultDTO : AopObject
    {
        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public long InvoiceId { get; set; }

        /// <summary>
        /// 处理结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 处理结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succeeded")]
        public bool Succeeded { get; set; }
    }
}
