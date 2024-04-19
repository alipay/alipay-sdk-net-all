using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskCreateResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 受理号。资金管控任务的执行实际为异步执行，在查询或消息推送时，会返回改号作为查询依据
        /// </summary>
        [XmlElement("accepted_no")]
        public string AcceptedNo { get; set; }

        /// <summary>
        /// 授权跳转链接，成功时返回；用于授权开户协议
        /// </summary>
        [XmlElement("authorization_link")]
        public string AuthorizationLink { get; set; }

        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }

        /// <summary>
        /// 授权链接有效期
        /// </summary>
        [XmlElement("link_expiry")]
        public string LinkExpiry { get; set; }
    }
}
