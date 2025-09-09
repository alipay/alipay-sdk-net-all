using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentContractDictVo Data Structure.
    /// </summary>
    [Serializable]
    public class RentContractDictVo : AopObject
    {
        /// <summary>
        /// 字典码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 字典内容
        /// </summary>
        [XmlElement("dict_content")]
        public string DictContent { get; set; }
    }
}
