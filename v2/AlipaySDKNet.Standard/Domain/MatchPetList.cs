using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MatchPetList Data Structure.
    /// </summary>
    [Serializable]
    public class MatchPetList : AopObject
    {
        /// <summary>
        /// 建档接口返回的宠物档案唯一标识
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 同宠匹配置信度得分 0-100 范围内的数字，分数越大可信度越高
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
