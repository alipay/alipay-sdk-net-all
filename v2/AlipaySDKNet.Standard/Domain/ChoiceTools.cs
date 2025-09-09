using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChoiceTools Data Structure.
    /// </summary>
    [Serializable]
    public class ChoiceTools : AopObject
    {
        /// <summary>
        /// 为true代表此工具一定被执行。注意，只会执行第一个一定执行的工具
        /// </summary>
        [XmlElement("expected")]
        public bool Expected { get; set; }

        /// <summary>
        /// 指定的工具ID（只有此agent关联的工具才生效）
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 调用工具时的预设参数，json字符串形式的参数集合
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 运行时动态工具配置，如果列表非空，本轮执行的工具一定在此列表范围内（白名单）。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
