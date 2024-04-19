using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlescenterDocusignQueryResponse : AopResponse
    {
        /// <summary>
        /// 签署任务状态和多方签署人细分状态
        /// </summary>
        [XmlArray("recipient_sign_status_result_list")]
        [XmlArrayItem("recipient_sign_status_result")]
        public List<RecipientSignStatusResult> RecipientSignStatusResultList { get; set; }
    }
}
