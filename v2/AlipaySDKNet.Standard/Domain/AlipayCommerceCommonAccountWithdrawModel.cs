using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonAccountWithdrawModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonAccountWithdrawModel : AopObject
    {
        /// <summary>
        /// 账本id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 提现金额，大于0，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签约账户id
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 签约账户openid
        /// </summary>
        [XmlElement("sign_user_open_id")]
        public string SignUserOpenId { get; set; }
    }
}
