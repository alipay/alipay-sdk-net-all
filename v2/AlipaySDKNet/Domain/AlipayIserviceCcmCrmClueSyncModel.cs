using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmClueSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmClueSyncModel : AopObject
    {
        /// <summary>
        /// 线索的客户名称，区分为个人线索和企业线索，个人线索传名称，企业线索传公司名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 扩展信息字段有以下字段： 1. **用户标签 (user_labels)**: 可以枚举为 "老用户", "新用户"。 2 **电话是否接通 (is_tel_ok)**: 枚举值为 "是", "否"。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 业务方的客户ID，保证全局唯一(幂等处理)，示例值：1278789a
        /// </summary>
        [XmlElement("external_contact_id")]
        public string ExternalContactId { get; set; }

        /// <summary>
        /// 客资线索所对应的手机号码，明文
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 是否开启服务群的通知。开启后，使用该接口同步线索时服务群会收到通知
        /// </summary>
        [XmlElement("open_notify")]
        public bool OpenNotify { get; set; }

        /// <summary>
        /// 智能拓客平台租户ID,参数类型为字符串string类型,示例值："VTGhsiqj8791n"
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 是否使用虚拟号码，默认为false。
        /// </summary>
        [XmlElement("use_virtual_phone")]
        public bool UseVirtualPhone { get; set; }

        /// <summary>
        /// 虚拟号码，当使用虚拟号码的开关user_virtual_phone设置为true并且虚拟号类型Virtual_phone_type设置为MANUAL后生效。
        /// </summary>
        [XmlElement("virtual_phone")]
        public string VirtualPhone { get; set; }

        /// <summary>
        /// 虚拟号类型，默认为自动生成。目前有两种方式，一种是系统生成方案，参数为AUTO_GENERATE；另一种是调用方指定的方式，参数为MANUAL
        /// </summary>
        [XmlElement("virtual_phone_type")]
        public string VirtualPhoneType { get; set; }
    }
}
