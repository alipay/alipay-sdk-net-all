using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SingleDynamicData Data Structure.
    /// </summary>
    [Serializable]
    public class SingleDynamicData : AopObject
    {
        /// <summary>
        /// 过期时间，单位为秒
        /// </summary>
        [XmlElement("expire")]
        public long Expire { get; set; }

        /// <summary>
        /// key-value格式的透传参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 优先级，一个用户同一个appid有多个动效时，优先显示优先级高的
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 业务状态唯一性标识
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
