using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LucContactWayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LucContactWayInfo : AopObject
    {
        /// <summary>
        /// 联系方式类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 联系方式值，手机号码：13800138000，固定电话（区号-电话）：0571-888888XX，其他电话：10位400/800电话 
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
