using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FaceExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceExtInfo : AopObject
    {
        /// <summary>
        /// 年龄区间判断的上限，闭区间
        /// </summary>
        [XmlElement("max_age")]
        public string MaxAge { get; set; }

        /// <summary>
        /// 年龄区间判断的下限，闭区间
        /// </summary>
        [XmlElement("min_age")]
        public string MinAge { get; set; }

        /// <summary>
        /// query_type不填, 返回uid  query_type=1, 返回手机号  query_type=2, 返回图片
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
