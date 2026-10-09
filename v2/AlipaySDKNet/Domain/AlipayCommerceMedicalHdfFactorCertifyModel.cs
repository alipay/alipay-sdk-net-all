using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfFactorCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfFactorCertifyModel : AopObject
    {
        /// <summary>
        /// 192不带人像验证194带人像验证 isChineseIdCard为false比填
        /// </summary>
        [XmlElement("auth_mode")]
        public string AuthMode { get; set; }

        /// <summary>
        /// 缓存有效期（秒），<=0 直接外部取数并刷新缓存，默认0
        /// </summary>
        [XmlElement("cache_interval")]
        public string CacheInterval { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 华侨护照、大陆护照414； 港澳居民来往内地通行证516（中国籍）； 港澳居民来往内地通行证526（非中国籍）； 外国人永久居留身份证553； 台湾居民来往大陆通行证511；isChineseIdCard为false比填
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 是否中国身份证true是false否
        /// </summary>
        [XmlElement("is_chinese_id_card")]
        public bool IsChineseIdCard { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 国籍，如："CHN"； isChineseIdCard为false比填
        /// </summary>
        [XmlElement("nation")]
        public string Nation { get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        [XmlElement("photo_data")]
        public string PhotoData { get; set; }
    }
}
