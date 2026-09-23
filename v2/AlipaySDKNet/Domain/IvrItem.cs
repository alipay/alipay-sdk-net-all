using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IvrItem Data Structure.
    /// </summary>
    [Serializable]
    public class IvrItem : AopObject
    {
        /// <summary>
        /// 关联流程code（下拉选中值，对应任务taskIVRCode/transferCode）
        /// </summary>
        [XmlElement("ivr_code")]
        public string IvrCode { get; set; }

        /// <summary>
        /// 流程名称（下拉显示）
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
