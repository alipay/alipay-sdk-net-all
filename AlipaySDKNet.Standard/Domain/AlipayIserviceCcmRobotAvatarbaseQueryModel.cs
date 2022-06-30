using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotAvatarbaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotAvatarbaseQueryModel : AopObject
    {
        /// <summary>
        /// method_params:对应target_method请求方法的具体传参值k-v map
        /// </summary>
        [XmlElement("method_params")]
        public string MethodParams { get; set; }

        /// <summary>
        /// targetMethod；数字人目标方法调用
        /// </summary>
        [XmlElement("target_method")]
        public string TargetMethod { get; set; }
    }
}
