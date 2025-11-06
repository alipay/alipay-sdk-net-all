using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCloudplatformModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCloudplatformModifyModel : AopObject
    {
        /// <summary>
        /// 更新客户云平台信息请求参数
        /// </summary>
        [XmlElement("create_or_update_customer_cloud_platform_request")]
        public FxiaokeCreateOrUpdateCustomerCloudPlatformRequest CreateOrUpdateCustomerCloudPlatformRequest { get; set; }
    }
}
