using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCloudplatformCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCloudplatformCreateModel : AopObject
    {
        /// <summary>
        /// 创建客户云平台信息请求参数
        /// </summary>
        [XmlElement("create_or_update_customer_cloud_platform_request")]
        public FxiaokeCreateOrUpdateCustomerCloudPlatformRequest CreateOrUpdateCustomerCloudPlatformRequest { get; set; }
    }
}
