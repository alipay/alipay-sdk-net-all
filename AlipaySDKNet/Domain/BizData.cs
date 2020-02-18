using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizData Data Structure.
    /// </summary>
    [Serializable]
    public class BizData : AopObject
    {
        /// <summary>
        /// 素材内容数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务数据唯一标识
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
