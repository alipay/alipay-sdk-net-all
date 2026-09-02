using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodCategorypropertyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodCategorypropertyQueryModel : AopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
