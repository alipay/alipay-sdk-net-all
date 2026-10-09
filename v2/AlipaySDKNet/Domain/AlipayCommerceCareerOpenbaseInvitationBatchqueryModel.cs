using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseInvitationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCareerOpenbaseInvitationBatchqueryModel : AopObject
    {
        /// <summary>
        /// 平台生成的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 外部客户生成的批次号
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 外部某个批次明细的业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
