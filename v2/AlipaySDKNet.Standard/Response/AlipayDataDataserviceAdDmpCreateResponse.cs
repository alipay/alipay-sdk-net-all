using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdDmpCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAdDmpCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建或更新人群包成功时返回的人群包编码
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 创建或更新人群包成功时返回的人群包名称，人群包名称不能重复
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 调用接口上传设备号数据时返回的创建、更新人群状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
