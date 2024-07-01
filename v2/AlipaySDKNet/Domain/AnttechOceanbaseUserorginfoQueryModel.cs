using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseUserorginfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseUserorginfoQueryModel : AopObject
    {
        /// <summary>
        /// 邮箱或者手机号
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
