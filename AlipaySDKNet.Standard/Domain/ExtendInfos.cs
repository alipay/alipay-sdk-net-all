using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtendInfos Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendInfos : AopObject
    {
        /// <summary>
        /// isv_pid
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
