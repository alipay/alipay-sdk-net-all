using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrePayOperationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrePayOperationInfo : AopObject
    {
        /// <summary>
        /// 运营场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 运营展示数据
        /// </summary>
        [XmlElement("view_data")]
        public PrePayOperationInfoViewData ViewData { get; set; }
    }
}
