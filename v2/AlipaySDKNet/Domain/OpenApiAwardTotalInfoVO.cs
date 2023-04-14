using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiAwardTotalInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiAwardTotalInfoVO : AopObject
    {
        /// <summary>
        /// 助力者奖项信息
        /// </summary>
        [XmlElement("invitee_info")]
        public OpenApiAwardInfo InviteeInfo { get; set; }

        /// <summary>
        /// 邀请者奖项信息
        /// </summary>
        [XmlElement("inviter_info")]
        public OpenApiAwardInfo InviterInfo { get; set; }
    }
}
