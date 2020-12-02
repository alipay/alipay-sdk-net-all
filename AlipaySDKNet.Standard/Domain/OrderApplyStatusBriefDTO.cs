using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderApplyStatusBriefDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderApplyStatusBriefDTO : AopObject
    {
        /// <summary>
        /// SUCCESS：开票成功 FAIL：开票失败 PROCESS：开票中 NOTEXIST：申请不存在
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 开票申请时传入订单号（支持主单号、子单号），不限是否为支付宝体内交易单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
