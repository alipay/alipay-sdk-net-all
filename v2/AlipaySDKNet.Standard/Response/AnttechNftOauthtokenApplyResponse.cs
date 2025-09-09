using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftOauthtokenApplyResponse.
    /// </summary>
    public class AnttechNftOauthtokenApplyResponse : AopResponse
    {
        /// <summary>
        /// 后续调用接口鉴权的token，有效期30天
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// accessToken到期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 鲸探用户ID标识，OpenApi场景使用的加密格式
        /// </summary>
        [XmlElement("open_user_id")]
        public string OpenUserId { get; set; }

        /// <summary>
        /// refreshToken到期时间
        /// </summary>
        [XmlElement("refresh_expire_time")]
        public string RefreshExpireTime { get; set; }

        /// <summary>
        /// 刷新token，有效期90天
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 请求消息id，全链路唯一标记，建议打印，排查问题需提供
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }
    }
}
