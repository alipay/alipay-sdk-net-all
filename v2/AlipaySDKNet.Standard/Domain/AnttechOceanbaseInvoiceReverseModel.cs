using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseInvoiceReverseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseInvoiceReverseModel : AopObject
    {
        /// <summary>
        /// 调用方的业务唯一键，可做幂等，保证同一个请求多次调用该唯一键不变
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型示例，非真实值，接入需要提起申请
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 创建人的域名
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 发票的业务主键
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 用来描述红冲的原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 发票红冲的备注内容
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }
    }
}
