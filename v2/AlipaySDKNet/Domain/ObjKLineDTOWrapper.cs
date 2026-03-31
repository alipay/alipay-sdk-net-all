using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjKLineDTOWrapper Data Structure.
    /// </summary>
    [Serializable]
    public class ObjKLineDTOWrapper : AopObject
    {
        /// <summary>
        /// 业务数据，类型为ObjKLineDTOWrapper
        /// </summary>
        [XmlElement("data")]
        public ObjKLineDTO Data { get; set; }
    }
}
