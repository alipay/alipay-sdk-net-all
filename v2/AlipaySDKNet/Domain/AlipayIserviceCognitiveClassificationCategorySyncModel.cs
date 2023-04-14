using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationCategorySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveClassificationCategorySyncModel : AopObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 垃圾数据
        /// </summary>
        [XmlArray("rubbish_list")]
        [XmlArrayItem("rubbish_d_t_o")]
        public List<RubbishDTO> RubbishList { get; set; }
    }
}
