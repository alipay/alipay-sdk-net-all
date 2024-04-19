using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudDevopsDeviceConditionQueryResponse.
    /// </summary>
    public class AlipayCloudDevopsDeviceConditionQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备架构
        /// </summary>
        [XmlElement("abi")]
        public string Abi { get; set; }

        /// <summary>
        /// 设备品牌型号信息
        /// </summary>
        [XmlElement("brand_product")]
        public string BrandProduct { get; set; }

        /// <summary>
        /// 屏幕像素密度
        /// </summary>
        [XmlElement("dpi")]
        public string Dpi { get; set; }

        /// <summary>
        /// 系统版本
        /// </summary>
        [XmlElement("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 设备屏幕分辨率
        /// </summary>
        [XmlElement("resolution")]
        public string Resolution { get; set; }
    }
}
