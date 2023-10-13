using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossSWsstestAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossSWsstestAddModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("address")]
        public ManjiangTestComplexOneData Address { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sssdsds")]
        public long Sssdsds { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_2")]
        public ParamValidateTest Test2 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
