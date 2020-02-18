using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterTradeStartContractApprovalResult Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradeStartContractApprovalResult : AopObject
    {
        /// <summary>
        /// true：需要蚂蚁关联交易审批 false：不需要蚂蚁关联交易审批
        /// </summary>
        [XmlElement("need_approval_flag")]
        public bool NeedApprovalFlag { get; set; }
    }
}
