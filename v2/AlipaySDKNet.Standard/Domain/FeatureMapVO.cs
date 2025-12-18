using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeatureMapVO Data Structure.
    /// </summary>
    [Serializable]
    public class FeatureMapVO : AopObject
    {
        /// <summary>
        /// 1：属性为营养成分属性 其他：非营养成分属性
        /// </summary>
        [XmlElement("nutritional_prop")]
        public string NutritionalProp { get; set; }
    }
}
