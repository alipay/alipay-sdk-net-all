using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityLabelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneContentCommunityLabelQueryModel : AopObject
    {
        /// <summary>
        /// 标签场景
        /// </summary>
        [XmlElement("label_scene")]
        public string LabelScene { get; set; }
    }
}
