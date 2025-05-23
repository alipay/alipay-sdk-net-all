using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcrowdDmpcrowdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcrowdDmpcrowdBatchqueryModel : AopObject
    {
        /// <summary>
        /// 该参数可支持模糊搜索dmp自定义人群包名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 该参数为灯火商家唯一标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 该参数表明查询dmp自定义人群时类型，INCLUDE: 自定义人群；EXCLUDE: 排除人群
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
