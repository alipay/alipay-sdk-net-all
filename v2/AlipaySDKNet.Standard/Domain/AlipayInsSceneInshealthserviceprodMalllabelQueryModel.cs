using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodMalllabelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodMalllabelQueryModel : AopObject
    {
        /// <summary>
        /// 一级类目ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
