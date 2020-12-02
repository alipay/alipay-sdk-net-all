using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeDataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步成功的数据ID，如有多个使用英文半角逗号分隔
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 结果码，发生异常时非空
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息，发生异常时非空
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
