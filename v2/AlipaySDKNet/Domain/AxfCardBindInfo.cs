using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfCardBindInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AxfCardBindInfo : AopObject
    {
        /// <summary>
        /// 绑卡状态
        /// </summary>
        [XmlElement("bind_card_status")]
        public bool BindCardStatus { get; set; }

        /// <summary>
        /// 商户绑卡时传入的用户名称
        /// </summary>
        [XmlElement("bind_user_name")]
        public string BindUserName { get; set; }

        /// <summary>
        /// 商户绑卡时传入的手机号
        /// </summary>
        [XmlElement("bind_user_phone")]
        public string BindUserPhone { get; set; }
    }
}
