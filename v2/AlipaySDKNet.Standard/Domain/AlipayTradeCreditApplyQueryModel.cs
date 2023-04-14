using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditApplyQueryModel : AopObject
    {
        /// <summary>
        /// 本次授信拆分申请时的被授信方授信来源
        /// </summary>
        [XmlElement("buyer_credit_source")]
        public string BuyerCreditSource { get; set; }

        /// <summary>
        /// 本次授信拆分申请时的被授信方的userId
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 标识本次授信拆分的业务场景，具体的值由支付宝定义
        /// </summary>
        [XmlElement("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 本次授信拆分的操作单号
        /// </summary>
        [XmlElement("grant_operation_no")]
        public string GrantOperationNo { get; set; }

        /// <summary>
        /// 本次授信拆分申请时的外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
