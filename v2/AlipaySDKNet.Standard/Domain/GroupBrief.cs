using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupBrief Data Structure.
    /// </summary>
    [Serializable]
    public class GroupBrief : AopObject
    {
        /// <summary>
        /// 群创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群头像url
        /// </summary>
        [XmlElement("group_img")]
        public string GroupImg { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 群主id
        /// </summary>
        [XmlElement("master_uid")]
        public string MasterUid { get; set; }

        /// <summary>
        /// 商家open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
