using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserLabels Data Structure.
    /// </summary>
    [Serializable]
    public class UserLabels : AopObject
    {
        /// <summary>
        /// 当前参数为标签名称对应的属性编码（Code），其定义源自数据服务平台。
        /// </summary>
        [XmlElement("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 当前参数为源自数据服务平台定义的标签名称属性
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 该参数表示标签值，用于标识对应标签的具体取值。
        /// </summary>
        [XmlElement("label_value")]
        public string LabelValue { get; set; }
    }
}
