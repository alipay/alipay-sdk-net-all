using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceHuidutestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceHuidutestQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user")]
        public HuiDuTest User { get; set; }
    }
}
