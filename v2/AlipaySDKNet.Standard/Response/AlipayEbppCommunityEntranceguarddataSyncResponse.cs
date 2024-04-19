using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityEntranceguarddataSyncResponse.
    /// </summary>
    public class AlipayEbppCommunityEntranceguarddataSyncResponse : AopResponse
    {
        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
