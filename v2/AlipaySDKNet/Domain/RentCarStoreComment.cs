using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarStoreComment Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarStoreComment : AopObject
    {
        /// <summary>
        /// 评价内容，100字以内
        /// </summary>
        [XmlElement("comment_content")]
        public string CommentContent { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("comment_time")]
        public string CommentTime { get; set; }

        /// <summary>
        /// 门店评价类型
        /// </summary>
        [XmlElement("comment_type")]
        public string CommentType { get; set; }
    }
}
