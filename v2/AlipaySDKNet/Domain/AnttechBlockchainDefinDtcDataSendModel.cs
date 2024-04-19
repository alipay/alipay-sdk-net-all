using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDtcDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDtcDataSendModel : AopObject
    {
        /// <summary>
        /// 接口编码
        /// </summary>
        [XmlElement("api_code")]
        public string ApiCode { get; set; }

        /// <summary>
        /// 业务参数，json字符串
        /// </summary>
        [XmlElement("biz_param")]
        public string BizParam { get; set; }

        /// <summary>
        /// 请求幂等ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
