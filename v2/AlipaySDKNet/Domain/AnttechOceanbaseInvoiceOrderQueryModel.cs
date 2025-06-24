using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseInvoiceOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseInvoiceOrderQueryModel : AopObject
    {
        /// <summary>
        /// 发票申请后返回的业务单号
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 调用方主动传入的业务单号，标识着业务唯一
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型，标识着业务属性，新的接入需要申请新的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
