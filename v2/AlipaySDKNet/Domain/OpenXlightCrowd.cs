using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenXlightCrowd Data Structure.
    /// </summary>
    [Serializable]
    public class OpenXlightCrowd : AopObject
    {
        /// <summary>
        /// 人群包名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 人群包id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 人群包覆盖人群量级
        /// </summary>
        [XmlElement("user_num")]
        public string UserNum { get; set; }

        /// <summary>
        /// 该人群包的有效日期，如果该参数为空则表示该人群包无失效时间，永久有效
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
