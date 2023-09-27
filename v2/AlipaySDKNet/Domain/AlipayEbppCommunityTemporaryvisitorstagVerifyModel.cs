using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityTemporaryvisitorstagVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityTemporaryvisitorstagVerifyModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 快递员
        /// </summary>
        [XmlElement("tag_type")]
        public string TagType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
