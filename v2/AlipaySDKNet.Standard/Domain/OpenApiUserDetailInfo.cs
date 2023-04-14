using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiUserDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiUserDetailInfo : AopObject
    {
        /// <summary>
        /// 给被邀请人派奖是:Y 否:N
        /// </summary>
        [XmlElement("award_invitee")]
        public string AwardInvitee { get; set; }

        /// <summary>
        /// 给邀请人派奖 是:Y 否:N
        /// </summary>
        [XmlElement("award_inviter")]
        public string AwardInviter { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 被邀请人序列
        /// </summary>
        [XmlElement("index")]
        public string Index { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
