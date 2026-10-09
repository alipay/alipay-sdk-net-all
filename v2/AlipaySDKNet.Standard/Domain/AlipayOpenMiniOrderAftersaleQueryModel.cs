using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersaleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderAftersaleQueryModel : AopObject
    {
        /// <summary>
        /// 售后单号，和商家自定义售后单号二选一
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 买家open_id，和uid二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家自定义售后单号，和平台售后单号二选一
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
