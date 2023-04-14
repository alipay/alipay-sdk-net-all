using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppGrayGroupDto Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppGrayGroupDto : AopObject
    {
        /// <summary>
        /// 灰度分组code
        /// </summary>
        [XmlElement("gray_code")]
        public string GrayCode { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
