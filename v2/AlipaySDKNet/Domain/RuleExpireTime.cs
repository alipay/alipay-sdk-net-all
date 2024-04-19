using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleExpireTime Data Structure.
    /// </summary>
    [Serializable]
    public class RuleExpireTime : AopObject
    {
        /// <summary>
        /// 规则生效时间，当过期标识选true时必传
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 规则过期时间，当过期标识选true时必传
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 业务规则是否过期标识，true:过期限制，false:永不过期
        /// </summary>
        [XmlElement("expire_type")]
        public bool ExpireType { get; set; }
    }
}
