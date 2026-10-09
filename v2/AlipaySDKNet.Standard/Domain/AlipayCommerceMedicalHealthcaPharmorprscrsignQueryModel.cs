using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaPharmorprscrsignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthcaPharmorprscrsignQueryModel : AopObject
    {
        /// <summary>
        /// 历史请求唯一标识（取原先调用接口的requestId：1、创建二维码；2、处方PDF加签）
        /// </summary>
        [XmlElement("history_request_id")]
        public string HistoryRequestId { get; set; }

        /// <summary>
        /// 签署合同ID
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
