using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PopulationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PopulationDTO : AopObject
    {
        /// <summary>
        /// 用户消费能力信息
        /// </summary>
        [XmlArray("consume_level")]
        [XmlArrayItem("user_consume_level_tag_d_t_o")]
        public List<UserConsumeLevelTagDTO> ConsumeLevel { get; set; }

        /// <summary>
        /// 用户职业信息
        /// </summary>
        [XmlArray("occupation")]
        [XmlArrayItem("user_occupation_tag_d_t_o")]
        public List<UserOccupationTagDTO> Occupation { get; set; }

        /// <summary>
        /// 用户年龄信息
        /// </summary>
        [XmlArray("user_age")]
        [XmlArrayItem("user_age_tag_d_t_o")]
        public List<UserAgeTagDTO> UserAge { get; set; }

        /// <summary>
        /// 用户性别信息
        /// </summary>
        [XmlArray("user_gender")]
        [XmlArrayItem("user_gender_tag_d_t_o")]
        public List<UserGenderTagDTO> UserGender { get; set; }
    }
}
