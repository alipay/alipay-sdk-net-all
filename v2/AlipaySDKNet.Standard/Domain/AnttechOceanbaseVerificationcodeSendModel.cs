using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseVerificationcodeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseVerificationcodeSendModel : AopObject
    {
        /// <summary>
        /// 用户通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 场景码枚举：CLOUD_DELETE_CLUSTER多云删除集群。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
