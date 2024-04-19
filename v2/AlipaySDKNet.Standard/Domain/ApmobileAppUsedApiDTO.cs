using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppUsedApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppUsedApiDTO : AopObject
    {
        /// <summary>
        /// 隐私api描述
        /// </summary>
        [XmlElement("api_desc")]
        public string ApiDesc { get; set; }

        /// <summary>
        /// bundle信息
        /// </summary>
        [XmlElement("bundle")]
        public string Bundle { get; set; }

        /// <summary>
        /// 方法信息
        /// </summary>
        [XmlElement("method_info")]
        public string MethodInfo { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        [XmlElement("stmt")]
        public string Stmt { get; set; }
    }
}
