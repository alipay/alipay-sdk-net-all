using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryTreasurechestDataSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryTreasurechestDataSaveModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("save_data_item_d_t_o")]
        public List<SaveDataItemDTO> Items { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 在市民中心办事保险箱注册的授权场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
