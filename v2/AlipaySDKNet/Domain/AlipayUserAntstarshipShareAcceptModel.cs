using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntstarshipShareAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntstarshipShareAcceptModel : AopObject
    {
        /// <summary>
        /// 活动id 唯一
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 邀请日期
        /// </summary>
        [XmlElement("invite_date")]
        public string InviteDate { get; set; }

        /// <summary>
        /// 邀请ID
        /// </summary>
        [XmlElement("inviter_id")]
        public string InviterId { get; set; }

        /// <summary>
        /// 单品id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
