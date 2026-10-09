using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceJinyoutestSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceJinyoutestSyncModel : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("t_1_f")]
        public JinyouTestFive T1F { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_1_n")]
        public string T1N { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_1_openid")]
        public string T1Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_1_y")]
        public string T1Y { get; set; }
    }
}
