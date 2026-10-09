using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdEdgeColorfeedbackCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdEdgeColorfeedbackCreateModel : AopObject
    {
        /// <summary>
        /// 该参数为业务反馈的自定义参数
        /// </summary>
        [XmlElement("biz_param")]
        public string BizParam { get; set; }

        /// <summary>
        /// 该参数为终端安全分配给业务的token字符串，业务需要妥善保存token并且在查询请求时传入
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 该字段为客户端风险信息接口返回的设备风险信息
        /// </summary>
        [XmlElement("sec_info")]
        public string SecInfo { get; set; }

        /// <summary>
        /// 该参数为支付宝客户端分配的小程序Id
        /// </summary>
        [XmlElement("tinyapp_id")]
        public string TinyappId { get; set; }

        /// <summary>
        /// 该参数为客户端风险信息接口返回的traceId
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
