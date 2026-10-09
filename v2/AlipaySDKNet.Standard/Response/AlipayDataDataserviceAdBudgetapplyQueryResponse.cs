using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdBudgetapplyQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdBudgetapplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 实际划拨金额明细，资金端未返回时为空 单位为“元”，支持两位小数
        /// </summary>
        [XmlElement("amount_detail")]
        public AmountDetail AmountDetail { get; set; }

        /// <summary>
        /// 第三方申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 资金当前流水状态：处理中-WAITING；成功-SUCCESS；失败-FAIL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
