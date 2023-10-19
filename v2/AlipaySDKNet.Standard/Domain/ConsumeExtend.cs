using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumeExtend Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumeExtend : AopObject
    {
        /// <summary>
        /// 是否支持圈店宝
        /// </summary>
        [XmlElement("mall_assign_store")]
        public bool MallAssignStore { get; set; }
    }
}
