using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntCasignCreateResponse.
    /// </summary>
    public class AlipayBossProdAntCasignCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 签约流程id
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }

        /// <summary>
        /// 用印子任务受理流水
        /// </summary>
        [XmlElement("sub_ant_sign_result_list")]
        public SubAntSignResult SubAntSignResultList { get; set; }
    }
}
