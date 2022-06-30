using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReplyRecord Data Structure.
    /// </summary>
    [Serializable]
    public class ReplyRecord : AopObject
    {
        /// <summary>
        /// 回复内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 回复图片
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 回复角色 商家：MERCHANT  审核小二：AUDITOR
        /// </summary>
        [XmlElement("replier_role")]
        public string ReplierRole { get; set; }

        /// <summary>
        /// 状态。只在replier_role = ‘AUDITOR’时有值。 appealSuccess：申诉通过 appealFailed：申诉不通过 rectifyPass：整改通过 rectifyReject：整改不通过
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
