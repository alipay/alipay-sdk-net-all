using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberAuthQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 医疗会员token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// alipay的id
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 有效 单位（天）
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }
    }
}
