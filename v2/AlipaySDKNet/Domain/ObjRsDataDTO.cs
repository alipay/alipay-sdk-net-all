using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjRsDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ObjRsDataDTO : AopObject
    {
        /// <summary>
        /// obj 维度
        /// </summary>
        [XmlElement("obj_dim_key")]
        public string ObjDimKey { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        [XmlElement("rs_data")]
        public RsData RsData { get; set; }
    }
}
