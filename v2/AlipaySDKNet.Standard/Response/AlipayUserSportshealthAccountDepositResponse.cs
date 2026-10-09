using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportshealthAccountDepositResponse.
    /// </summary>
    public class AlipayUserSportshealthAccountDepositResponse : AopResponse
    {
        /// <summary>
        /// 账户实际发放运动币数量
        /// </summary>
        [XmlElement("award_amount")]
        public long AwardAmount { get; set; }
    }
}
