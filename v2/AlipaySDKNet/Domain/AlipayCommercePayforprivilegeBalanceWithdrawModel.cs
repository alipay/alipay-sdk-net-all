using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePayforprivilegeBalanceWithdrawModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePayforprivilegeBalanceWithdrawModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 提现金额，单位元。需要小于余额中可提现金额
        /// </summary>
        [XmlElement("withdraw_amount")]
        public string WithdrawAmount { get; set; }
    }
}
