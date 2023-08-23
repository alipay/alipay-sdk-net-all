using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfSignprocessQueryResponse.
    /// </summary>
    public class AlipayEbppJfSignprocessQueryResponse : AopResponse
    {
        /// <summary>
        /// 缴费代扣协议唯一标识, 后续解约唯一标识
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 由于机构的特殊性, 最终签约结果以机构反馈结果为准,输出错误码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 由于机构的特殊性, 最终签约结果以机构反馈结果为准,输出错误信息
        /// </summary>
        [XmlElement("org_msg")]
        public string OrgMsg { get; set; }

        /// <summary>
        /// 异步签约流程对应的当前状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
