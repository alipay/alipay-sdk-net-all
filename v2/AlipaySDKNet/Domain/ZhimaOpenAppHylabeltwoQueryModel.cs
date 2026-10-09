using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenAppHylabeltwoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppHylabeltwoQueryModel : AopObject
    {
        /// <summary>
        /// 公司名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("opr_scope")]
        public string OprScope { get; set; }
    }
}
