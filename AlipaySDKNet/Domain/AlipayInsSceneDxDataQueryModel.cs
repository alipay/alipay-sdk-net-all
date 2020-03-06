using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneDxDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneDxDataQueryModel : AopObject
    {
        /// <summary>
        /// dx服务名
        /// </summary>
        [XmlElement("dx_name")]
        public string DxName { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }
    }
}
