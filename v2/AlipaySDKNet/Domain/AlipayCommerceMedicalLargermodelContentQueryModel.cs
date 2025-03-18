using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelContentQueryModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 01:身份证,02:护照,03:军官证,04:士兵证,05:户口本,06:警官证,07:台湾居民来往大陆通行证（简称“回乡证”）,08:港澳居民来往内地通行证（简称“回乡证”）,09:临时身份证,10:港澳通行证,11:营业执照,13:香港身份证,15:组织机构代码证,16:行政机关,17:社会团体,19:台湾居民来往大陆通行证,20:港澳居民居住证,21:台湾居民居住证,22:外国人永久居留证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 参保城市编码
        /// </summary>
        [XmlElement("insured_city_code")]
        public string InsuredCityCode { get; set; }

        /// <summary>
        /// 纬度 无需携带单位符号
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度 无需携带单位符号
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用于区分同一个app下的机构
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID；若是open_id时，设置为ALIPAY_OPENID
        /// </summary>
        [XmlElement("out_user_type")]
        public string OutUserType { get; set; }

        /// <summary>
        /// 页面id，指定哪个页面模板来获取数据
        /// </summary>
        [XmlElement("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// ADB查询adb的数据 LLM表示查询大模型的数据
        /// </summary>
        [XmlElement("query_stage")]
        public string QueryStage { get; set; }

        /// <summary>
        /// 区分当前对话场景意图 待分配后传入固定值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
    }
}
