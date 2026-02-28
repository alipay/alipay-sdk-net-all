using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowAllowedAccount Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowAllowedAccount : AopObject
    {
        /// <summary>
        /// 入金通知场景下代表付款方的户名
        /// </summary>
        [XmlElement("allowed_account_name")]
        public string AllowedAccountName { get; set; }

        /// <summary>
        /// 入金通知场景下代表付款方的卡号
        /// </summary>
        [XmlElement("allowed_account_no")]
        public string AllowedAccountNo { get; set; }

        /// <summary>
        /// 白名单中的单个元素类型 当业务场景为'入金通知'时白名单的账户类型为:PAYER(付款方)
        /// </summary>
        [XmlElement("allowed_account_type")]
        public string AllowedAccountType { get; set; }

        /// <summary>
        /// 到期时间(如果不填,代表一直有效,直到重新调用更新接口)，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }
    }
}
