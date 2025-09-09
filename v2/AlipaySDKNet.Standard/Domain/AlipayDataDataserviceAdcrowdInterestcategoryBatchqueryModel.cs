using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcrowdInterestcategoryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcrowdInterestcategoryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 该参数为搜索兴趣人群类目时填写的搜索词，填写后查询结果将包含填写的词。
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 该参数为灯火商家唯一标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
