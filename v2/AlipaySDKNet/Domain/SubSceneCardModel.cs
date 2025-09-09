using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubSceneCardModel Data Structure.
    /// </summary>
    [Serializable]
    public class SubSceneCardModel : AopObject
    {
        /// <summary>
        /// 子场景卡列表
        /// </summary>
        [XmlArray("sub_scene_card_list")]
        [XmlArrayItem("special_card_info_model")]
        public List<SpecialCardInfoModel> SubSceneCardList { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("sub_scene_code")]
        public string SubSceneCode { get; set; }

        /// <summary>
        /// 子场景码名称
        /// </summary>
        [XmlElement("sub_scene_code_name")]
        public string SubSceneCodeName { get; set; }
    }
}
