using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvRsResultGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvRsResultGetModel : AopObject
    {
        /// <summary>
        /// 要查询预测数据的围栏经纬度信息
        /// </summary>
        [XmlElement("geo")]
        public string Geo { get; set; }
    }
}
