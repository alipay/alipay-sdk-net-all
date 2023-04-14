using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataDataserviceTestaaaSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceTestaaaSendModel : AopObject
    {
        /// <summary>
        /// 座机号码
        /// </summary>
        [XmlElement("tes_1")]
        public string Tes1 { get; set; }

        /// <summary>
        /// 222
        /// </summary>
        [XmlElement("test_2")]
        public string Test2 { get; set; }
    }
}
