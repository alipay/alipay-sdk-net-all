using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvertQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionAdvertQueryResponse : AopResponse
    {
        /// <summary>
        /// 推广详情集合
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("kb_advert_adv_response")]
        public List<KbAdvertAdvResponse> Data { get; set; }
    }
}
