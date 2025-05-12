using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyAcardTaskApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyAcardTaskApplyModel : AopObject
    {
        /// <summary>
        /// 卡操作的类型 枚举值： ● NEW：制新卡 ● REPLACE：覆盖卡权限 ● MODIFY：修改卡权限 ● DELETE：删卡
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("auth_devices")]
        [XmlArrayItem("gate_device_info")]
        public List<GateDeviceInfo> AuthDevices { get; set; }

        /// <summary>
        /// 卡号，该制卡任务对应的卡号。hex string格式，两位字母标识一个字节。大小写不敏感，长度视卡协议类型而定，可能是8（4字节）、14（7字节）等、16（8字节）。
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 制卡模板code，卡模板为客户入驻后在平台配置的内容，包括对应小区、卡协议、密钥等
        /// </summary>
        [XmlElement("card_template_code")]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("forbid_devices")]
        [XmlArrayItem("gate_device_info")]
        public List<GateDeviceInfo> ForbidDevices { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部客户保证唯一性，平台以此字段作幂等性处理
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 平台接收来自客户系统的请求，给到发卡设备消费
        /// </summary>
        [XmlElement("transparent_data")]
        public string TransparentData { get; set; }

        /// <summary>
        /// 支付宝用户UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
