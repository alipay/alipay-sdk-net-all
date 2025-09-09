using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftPoapDistributeSubmitResponse.
    /// </summary>
    public class AnttechNftPoapDistributeSubmitResponse : AopResponse
    {
        /// <summary>
        /// 勋章ID
        /// </summary>
        [XmlElement("medal_id")]
        public string MedalId { get; set; }

        /// <summary>
        /// 勋章元数据id
        /// </summary>
        [XmlElement("medal_meta_id")]
        public long MedalMetaId { get; set; }
    }
}
