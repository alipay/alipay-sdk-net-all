using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterprisePayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnterprisePayInfo : AopObject
    {
        /// <summary>
        /// 因公付业务信息
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }
    }
}
