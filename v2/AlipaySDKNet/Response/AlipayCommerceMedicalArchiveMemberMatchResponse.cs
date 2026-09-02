using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalArchiveMemberMatchResponse.
    /// </summary>
    public class AlipayCommerceMedicalArchiveMemberMatchResponse : AopResponse
    {
        /// <summary>
        /// true-匹配到的档案成员为本人； false-未匹配到本人  当匹配到本人
        /// </summary>
        [XmlElement("is_matched_self")]
        public bool IsMatchedSelf { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("matched_member_list")]
        [XmlArrayItem("matched_member_d_t_o")]
        public List<MatchedMemberDTO> MatchedMemberList { get; set; }
    }
}
