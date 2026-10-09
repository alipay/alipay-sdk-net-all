using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GeographyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GeographyInfo : AopObject
    {
        /// <summary>
        /// 省份城市区编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 匹配得分，整数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
