using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneReleaseModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoSceneReleaseModel : AopObject
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// 坑位码，入参必须为数字或者英文字母
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
