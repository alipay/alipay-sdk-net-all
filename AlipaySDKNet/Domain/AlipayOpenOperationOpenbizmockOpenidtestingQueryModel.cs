using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockOpenidtestingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockOpenidtestingQueryModel : AopObject
    {
        /// <summary>
        /// adadsad
        /// </summary>
        [XmlElement("extra_json")]
        public string ExtraJson { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("extra_json_1")]
        public string ExtraJson1 { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("test")]
        public OpenidComplex Test { get; set; }

        /// <summary>
        /// 测试循环嵌套含有json数组和对象
        /// </summary>
        [XmlElement("test_json")]
        public string TestJson { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_wrong")]
        public string TestWrong { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("user_detail")]
        public UserDetail UserDetail { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
