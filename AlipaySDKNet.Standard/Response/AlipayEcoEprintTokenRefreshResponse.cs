using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEprintTokenRefreshResponse.
    /// </summary>
    public class AlipayEcoEprintTokenRefreshResponse : AopResponse
    {
        /// <summary>
        /// 访问易联云凭证
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 预计过期时间秒
        /// </summary>
        [XmlElement("expected_expires_in")]
        public string ExpectedExpiresIn { get; set; }

        /// <summary>
        /// 过期时长秒
        /// </summary>
        [XmlElement("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 4004578279
        /// </summary>
        [XmlElement("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 更新AccessToken凭证
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
