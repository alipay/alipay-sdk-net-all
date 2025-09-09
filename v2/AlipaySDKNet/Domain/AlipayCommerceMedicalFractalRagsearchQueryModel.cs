using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFractalRagsearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFractalRagsearchQueryModel : AopObject
    {
        /// <summary>
        /// 通行证code
        /// </summary>
        [XmlElement("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [XmlElement("extra_params")]
        public string ExtraParams { get; set; }

        /// <summary>
        /// 最大结果数
        /// </summary>
        [XmlElement("max_results")]
        public string MaxResults { get; set; }

        /// <summary>
        /// 查询字符串
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
