using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceApplyStatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceApplyStatusNotifyModel : AopObject
    {
        /// <summary>
        /// 发票申请ID，由阿里发票平台生成。字母或数字组成。 申请单的唯一标识，幂等字段。
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请状态，可选值： applying: 申请中，初始状态； cancelled: 申请已取消、或商户已驳回； creating_inv: 商户已受理/开票中，待发票结果回传； inv_failed: 开票失败； inv_success: 开票成功； inv_part_success: 部分成功（拆单场景下存在。举例：发票申请拆单之后有10张票，其中有1张开票成功时，此时申请状态为inv_part_success，当10张票全部成功申请状态则为inv_success）
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 该申请下所有已开具成功的发票。 状态变更为 apply_status=inv_success 时该字段必传
        /// </summary>
        [XmlArray("invoice_uks")]
        [XmlArrayItem("invoice_uk_d_t_o")]
        public List<InvoiceUkDTO> InvoiceUks { get; set; }

        /// <summary>
        /// 说明信息：驳回或失败原因 apply_status=inv_failed 或 apply_status=cancelled 时必传
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
