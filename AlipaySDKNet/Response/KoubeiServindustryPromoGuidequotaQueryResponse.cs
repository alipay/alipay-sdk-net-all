using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryPromoGuidequotaQueryResponse.
    /// </summary>
    public class KoubeiServindustryPromoGuidequotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 权限份额
        /// </summary>
        [XmlArray("auth_quota")]
        [XmlArrayItem("ig_auth_quota")]
        public List<IgAuthQuota> AuthQuota { get; set; }
    }
}
