using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardUserInfo : AopObject
    {
        /// <summary>
        /// 用户open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户唯一标识, 根据user_uni_id_type类型来定 （目前暂支持支付宝userId）  支付宝userId说明：支付宝用户号是以2088开头的16位纯数字组成
        /// </summary>
        [XmlElement("user_uni_id")]
        public string UserUniId { get; set; }

        /// <summary>
        /// 用户唯一标识类型
        /// </summary>
        [XmlElement("user_uni_id_type")]
        public string UserUniIdType { get; set; }
    }
}
