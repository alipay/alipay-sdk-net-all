using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenRejectResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenRejectResultDTO : AopObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 拦截原因编码
        /// </summary>
        [XmlElement("reject_reason_code")]
        public string RejectReasonCode { get; set; }

        /// <summary>
        /// 拦截原因描述
        /// </summary>
        [XmlElement("reject_reason_msg")]
        public string RejectReasonMsg { get; set; }
    }
}
