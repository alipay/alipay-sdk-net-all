using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthFieldDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AuthFieldDTO : AopObject
    {
        /// <summary>
        /// 接口英文名称
        /// </summary>
        [XmlElement("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 接口字段英文名称
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 接口归属的功能code
        /// </summary>
        [XmlElement("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// AUDIT 审核中，AGREE通过，REJECT驳回，INVALID无效（isv代申请场景)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户应用app_id
        /// </summary>
        [XmlElement("user_app_id")]
        public string UserAppId { get; set; }
    }
}
