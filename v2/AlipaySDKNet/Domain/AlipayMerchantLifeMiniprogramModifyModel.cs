using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantLifeMiniprogramModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantLifeMiniprogramModifyModel : AopObject
    {
        /// <summary>
        /// extra:服务商创建小程序的扩展信息
        /// </summary>
        [XmlElement("extra")]
        public MiniProgramExtraInfo Extra { get; set; }

        /// <summary>
        /// reason：服务商创建小程序的结果描述，失败时需要添加失败描述
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// requestId: 我方颁发的流程ID，用于处理流程信息
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// status: 服务商小程序创建状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
