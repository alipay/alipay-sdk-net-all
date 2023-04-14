using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PetMatchScores Data Structure.
    /// </summary>
    [Serializable]
    public class PetMatchScores : AopObject
    {
        /// <summary>
        /// 宠物ID
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 匹配值分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
