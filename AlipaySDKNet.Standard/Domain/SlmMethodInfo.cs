using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SlmMethodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SlmMethodInfo : AopObject
    {
        /// <summary>
        /// 方法功能的描述
        /// </summary>
        [XmlElement("method_desc")]
        public string MethodDesc { get; set; }

        /// <summary>
        /// 方法名
        /// </summary>
        [XmlElement("method_name")]
        public string MethodName { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        [XmlElement("param_info_list")]
        public ServeParamInfo ParamInfoList { get; set; }
    }
}
