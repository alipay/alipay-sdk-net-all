using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppSmartwearStatusQueryResponse.
    /// </summary>
    public class AlipayPayAppSmartwearStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 支持的产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 使用的安全方案
        /// </summary>
        [XmlElement("security_solution")]
        public string SecuritySolution { get; set; }

        /// <summary>
        /// 该设备的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
