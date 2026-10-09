using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportshealthAccountQueryResponse.
    /// </summary>
    public class AlipayUserSportshealthAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户运动币账户余额
        /// </summary>
        [XmlElement("balance_amount")]
        public long BalanceAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
