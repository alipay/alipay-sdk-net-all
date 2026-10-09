using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestGrasslandcertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestGrasslandcertQueryModel : AopObject
    {
        /// <summary>
        /// 分页游标，从0开始，时间戳
        /// </summary>
        [XmlElement("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 每页条数, 默认10条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 访问来源，业务自己定
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
