using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftTenantidFansidQueryResponse.
    /// </summary>
    public class AnttechNftTenantidFansidQueryResponse : AopResponse
    {
        /// <summary>
        /// 鲸探账号
        /// </summary>
        [XmlElement("fans_id")]
        public string FansId { get; set; }
    }
}
