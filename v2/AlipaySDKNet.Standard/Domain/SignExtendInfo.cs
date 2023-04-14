using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignExtendInfo : AopObject
    {
        /// <summary>
        /// isv 商户id
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
