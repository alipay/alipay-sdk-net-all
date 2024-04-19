using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceRecordCatRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceRecordCatRequest : AopObject
    {
        /// <summary>
        /// 类目名称(需要每一级用;分隔封装)
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }

        /// <summary>
        /// 一级类目编码
        /// </summary>
        [XmlElement("first_cat")]
        public string FirstCat { get; set; }

        /// <summary>
        /// 四级类目编码
        /// </summary>
        [XmlElement("fourth_cat")]
        public string FourthCat { get; set; }

        /// <summary>
        /// 类目树编码
        /// </summary>
        [XmlElement("instence_code")]
        public string InstenceCode { get; set; }

        /// <summary>
        /// 二级类目编码
        /// </summary>
        [XmlElement("second_cat")]
        public string SecondCat { get; set; }

        /// <summary>
        /// 三级类目编码
        /// </summary>
        [XmlElement("third_cat")]
        public string ThirdCat { get; set; }
    }
}
