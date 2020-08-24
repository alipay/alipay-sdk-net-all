using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAntestTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAntestTaskCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝版本
        /// </summary>
        [XmlElement("alipay_version")]
        public string AlipayVersion { get; set; }

        /// <summary>
        /// appId
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 用例列表
        /// </summary>
        [XmlElement("case_list")]
        public string CaseList { get; set; }

        /// <summary>
        /// 设备策略
        /// </summary>
        [XmlElement("device_strategy")]
        public string DeviceStrategy { get; set; }

        /// <summary>
        /// 2000002
        /// </summary>
        [XmlElement("mock_group_id")]
        public long MockGroupId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 测试策略
        /// </summary>
        [XmlElement("test_strategy")]
        public string TestStrategy { get; set; }
    }
}
