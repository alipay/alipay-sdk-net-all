using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePetprofilePlatformprofileModifyModel : AopObject
    {
        /// <summary>
        /// 宠物生日，档案生日不能早于2000年，且不能晚于当天。只能更新日期，不能更新年月:
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 宠物昵称，不能包含字母、数字和中文以外的字符
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 宠物ID
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 宠物照片列表
        /// </summary>
        [XmlArray("photos")]
        [XmlArrayItem("pet_photo")]
        public List<PetPhoto> Photos { get; set; }

        /// <summary>
        /// 是否绝育，0 否；1 是；2 未知
        /// </summary>
        [XmlElement("sterilization")]
        public long Sterilization { get; set; }
    }
}
