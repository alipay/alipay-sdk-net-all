using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceTradeeventSyncResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceTradeeventSyncResponse : AopResponse
    {
        /// <summary>
        /// 保单摘要数据
        /// </summary>
        [XmlArray("policy_list")]
        [XmlArrayItem("ins_open_policy_digest_d_t_o")]
        public List<InsOpenPolicyDigestDTO> PolicyList { get; set; }
    }
}
