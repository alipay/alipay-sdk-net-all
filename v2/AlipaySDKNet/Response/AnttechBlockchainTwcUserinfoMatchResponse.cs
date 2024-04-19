using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainTwcUserinfoMatchResponse.
    /// </summary>
    public class AnttechBlockchainTwcUserinfoMatchResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁统一会员ID对应的sha256的hash值
        /// </summary>
        [XmlElement("cousumer_id_hash")]
        public string CousumerIdHash { get; set; }

        /// <summary>
        /// 不匹配的原因描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 匹配是否成功
        /// </summary>
        [XmlElement("match_success")]
        public bool MatchSuccess { get; set; }
    }
}
