using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdOdpsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasCrowdOdpsCreateModel : AopObject
    {
        /// <summary>
        /// 人群基本信息
        /// </summary>
        [XmlElement("crowd_base_info_dto")]
        public CrowdBaseInfoDTO CrowdBaseInfoDto { get; set; }

        /// <summary>
        /// 操作人员ID+唯一+创建ODPS人群
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人员名称+不唯一+创建ODPS人群
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 机构名称+不唯一+创建ODPS人群
        /// </summary>
        [XmlElement("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 租户Code+唯一+创建ODPS人群
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
