using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileApiDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileApiDetailDTO : AopObject
    {
        /// <summary>
        /// api描述
        /// </summary>
        [XmlElement("api_desc")]
        public string ApiDesc { get; set; }

        /// <summary>
        /// bundle信息
        /// </summary>
        [XmlElement("bundle")]
        public string Bundle { get; set; }

        /// <summary>
        /// 信息名称
        /// </summary>
        [XmlElement("info_name")]
        public string InfoName { get; set; }

        /// <summary>
        /// 信息类型
        /// </summary>
        [XmlElement("info_type")]
        public string InfoType { get; set; }

        /// <summary>
        /// 具体调用方法
        /// </summary>
        [XmlElement("method_info")]
        public string MethodInfo { get; set; }

        /// <summary>
        /// 涉及到的权限信息，&代表且的关系，|代表或的关系
        /// </summary>
        [XmlElement("permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// 调用位置
        /// </summary>
        [XmlElement("stmt")]
        public string Stmt { get; set; }
    }
}
