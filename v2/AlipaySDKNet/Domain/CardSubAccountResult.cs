using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardSubAccountResult Data Structure.
    /// </summary>
    [Serializable]
    public class CardSubAccountResult : AopObject
    {
        /// <summary>
        /// 账户类型
        /// </summary>
        [XmlElement("account_belong")]
        public string AccountBelong { get; set; }

        /// <summary>
        /// 主户账户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 充值批次号
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 1.00
        /// </summary>
        [XmlElement("denomination")]
        public string Denomination { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 充值单号
        /// </summary>
        [XmlElement("recharge_no")]
        public string RechargeNo { get; set; }

        /// <summary>
        /// 子账户号
        /// </summary>
        [XmlElement("sub_account_no")]
        public string SubAccountNo { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("validate_date")]
        public string ValidateDate { get; set; }
    }
}
