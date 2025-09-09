using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftOauthuserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftOauthuserinfoQueryModel : AopObject
    {
        /// <summary>
        /// accessToken请求
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 请求唯一ID，用于链路跟踪和问题排查
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 默认可以不传; 如果要查询手机号，实名标记等信息，传user_ext_info
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }
    }
}
