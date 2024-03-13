using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtInfoApiConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ExtInfoApiConfig : AopObject
    {
        /// <summary>
        /// 经营的小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 主体Pid
        /// </summary>
        [XmlElement("sub_pid")]
        public string SubPid { get; set; }
    }
}
