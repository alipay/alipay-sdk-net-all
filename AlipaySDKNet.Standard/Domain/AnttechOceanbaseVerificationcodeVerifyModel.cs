using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseVerificationcodeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseVerificationcodeVerifyModel : AopObject
    {
        /// <summary>
        /// 验证码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 验证完是否立刻失效该验证码
        /// </summary>
        [XmlElement("invalid")]
        public bool Invalid { get; set; }

        /// <summary>
        /// 用户通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 场景码枚举：CLOUD_DELETE_CLUSTER多云删除集群
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
