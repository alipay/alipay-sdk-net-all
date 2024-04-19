using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceTagmetaCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceTagmetaCreateModel : AopObject
    {
        /// <summary>
        /// 标签名称，业务自定义
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签名称，租户内唯一，业务方自定义
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签级别，表示标签绑定在那个层级
        /// </summary>
        [XmlElement("tag_level")]
        public string TagLevel { get; set; }

        /// <summary>
        /// 租户，填写固定值CS_HELLOBIKE_MS
        /// </summary>
        [XmlElement("tenant_instance_id")]
        public string TenantInstanceId { get; set; }

        /// <summary>
        /// 值的补充信息，当value_type是ENUM时，必填，格式未json字符串
        /// </summary>
        [XmlElement("value_comment")]
        public string ValueComment { get; set; }

        /// <summary>
        /// 值类型，描述标签具体是什么数值类型
        /// </summary>
        [XmlElement("value_type")]
        public string ValueType { get; set; }
    }
}
