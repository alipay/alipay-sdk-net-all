using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentEnterpriseSealQuerystatusResponse.
    /// </summary>
    public class AlipayCommerceRentEnterpriseSealQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 文件http链接，状态为已签署时，返回链接信息
        /// </summary>
        [XmlElement("http_file_url")]
        public string HttpFileUrl { get; set; }

        /// <summary>
        /// 签署合同id
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }

        /// <summary>
        /// 签署状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
