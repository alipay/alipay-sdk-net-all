using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoSceneAddModel : AopObject
    {
        /// <summary>
        /// 商品id列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// 入参格式为数字或者英文字母
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
