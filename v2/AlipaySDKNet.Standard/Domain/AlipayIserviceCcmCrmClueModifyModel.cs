using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmClueModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmClueModifyModel : AopObject
    {
        /// <summary>
        /// 线索的客户名称，区分为个人线索和企业线索，个人线索传名称，企业线索传公司名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 数据id，为同步客户线索信息（sync）导入后的返回值
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 扩展信息字段有以下字段： 1. **用户标签 (user_labels)**: 枚举值为 "老用户", "新用户"。 2 **电话是否接通 (is_tel_ok)**: 枚举值为 "是", "否"。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 客资线索所对应的手机号码
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 租户实例id，必填，智能拓客平台分配
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
