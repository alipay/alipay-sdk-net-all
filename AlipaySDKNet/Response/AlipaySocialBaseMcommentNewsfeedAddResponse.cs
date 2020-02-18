using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseMcommentNewsfeedAddResponse.
    /// </summary>
    public class AlipaySocialBaseMcommentNewsfeedAddResponse : AopResponse
    {
        /// <summary>
        /// 新评论id
        /// </summary>
        [XmlElement("newsfeed_id")]
        public string NewsfeedId { get; set; }
    }
}
