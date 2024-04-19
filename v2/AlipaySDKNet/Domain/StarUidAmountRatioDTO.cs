using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StarUidAmountRatioDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StarUidAmountRatioDTO : AopObject
    {
        /// <summary>
        /// 分佣比率，格式:xx%
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 淘客用户id集合
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("string")]
        public List<string> UidList { get; set; }

        /// <summary>
        /// 淘客用户openId集合
        /// </summary>
        [XmlArray("user_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserOpenIdList { get; set; }
    }
}
