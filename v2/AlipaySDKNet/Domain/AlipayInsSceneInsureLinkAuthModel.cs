using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsureLinkAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsureLinkAuthModel : AopObject
    {
        /// <summary>
        /// 设备激活时间
        /// </summary>
        [XmlElement("device_activation_time")]
        public string DeviceActivationTime { get; set; }

        /// <summary>
        /// 设备SN码
        /// </summary>
        [XmlElement("device_serial_number")]
        public string DeviceSerialNumber { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("equipment_model")]
        public string EquipmentModel { get; set; }

        /// <summary>
        /// 登录用户id
        /// </summary>
        [XmlElement("login_user_id")]
        public string LoginUserId { get; set; }

        /// <summary>
        /// session过期时间（s）
        /// </summary>
        [XmlElement("out_session_expiration")]
        public string OutSessionExpiration { get; set; }

        /// <summary>
        /// session_id
        /// </summary>
        [XmlElement("out_session_id")]
        public string OutSessionId { get; set; }

        /// <summary>
        /// 合作商编码
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保险产品编码
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 客户端渠道
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
