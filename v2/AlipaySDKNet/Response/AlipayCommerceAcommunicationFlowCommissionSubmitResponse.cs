using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationFlowCommissionSubmitResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationFlowCommissionSubmitResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS:成功 FAIL:失败 EFFECT:已启用 INVALID:立即结束 AUDITING:提交审核 REFUSED:审核驳回 APPROVED:审核通过 NONE:未配置 CLOSE:关闭 DISABLE:失效
        /// </summary>
        [XmlElement("commission_state")]
        public string CommissionState { get; set; }

        /// <summary>
        /// 支付宝与机构之间的商品id映射码，需要包含关键信息：省份-运营商-面额
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
