using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationDcsMerchantqrcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationDcsMerchantqrcodeQueryModel : AopObject
    {
        /// <summary>
        /// 进件商户PID
        /// </summary>
        [XmlElement("apply_merchant_pid")]
        public string ApplyMerchantPid { get; set; }

        /// <summary>
        /// 运营服务商PID 当前字段已废弃(通过网关上下文活动对应的参数)
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 被运营商户PID 当前字段已废弃(通过网关上下文活动对应的参数)
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 联营计划标识
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 通过商户传递标识(直连/间连), 返回对应商户PID
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }
    }
}
