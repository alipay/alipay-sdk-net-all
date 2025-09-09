using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalNpsStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalNpsStatusQueryModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
