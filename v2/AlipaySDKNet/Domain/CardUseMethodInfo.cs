using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardUseMethodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardUseMethodInfo : AopObject
    {
        /// <summary>
        /// 用户核销方式类型
        /// </summary>
        [XmlElement("use_method_type")]
        public string UseMethodType { get; set; }

        /// <summary>
        /// 小程序使用链接，当use_method_type=“2”时生效
        /// </summary>
        [XmlElement("use_path")]
        public string UsePath { get; set; }
    }
}
