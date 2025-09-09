using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountOpenCreateResponse.
    /// </summary>
    public class AlipayFinancialnetAuthSpaccountOpenCreateResponse : AopResponse
    {
        /// <summary>
        /// 开户户号
        /// </summary>
        [XmlElement("opened_account")]
        public string OpenedAccount { get; set; }

        /// <summary>
        /// 开户用户id
        /// </summary>
        [XmlElement("opened_account_user_id")]
        public string OpenedAccountUserId { get; set; }

        /// <summary>
        /// 开户用户id
        /// </summary>
        [XmlElement("opened_account_user_open_id")]
        public string OpenedAccountUserOpenId { get; set; }
    }
}
