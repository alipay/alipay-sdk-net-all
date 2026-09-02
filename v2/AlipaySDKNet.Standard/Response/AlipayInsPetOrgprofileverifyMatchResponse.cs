using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsPetOrgprofileverifyMatchResponse.
    /// </summary>
    public class AlipayInsPetOrgprofileverifyMatchResponse : AopResponse
    {
        /// <summary>
        /// 匹配的宠物列表
        /// </summary>
        [XmlElement("match_pet_list")]
        public MatchPetList MatchPetList { get; set; }
    }
}
