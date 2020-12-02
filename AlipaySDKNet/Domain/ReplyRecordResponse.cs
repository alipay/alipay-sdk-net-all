using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReplyRecordResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ReplyRecordResponse : AopObject
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
        /// 回复人名称
        /// </summary>
        [XmlElement("replier_name")]
        public string ReplierName { get; set; }

        /// <summary>
        /// 用户：USER  商家：MERCHANT
        /// </summary>
        [XmlElement("replier_role")]
        public string ReplierRole { get; set; }
    }
}
