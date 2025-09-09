using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceRealPropertyBusiness Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceRealPropertyBusiness : AopObject
    {
        /// <summary>
        /// 跨地（市）标志
        /// </summary>
        [XmlElement("cross_city_flag")]
        public string CrossCityFlag { get; set; }

        /// <summary>
        /// 使用结束时间，yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 车牌号，最多三个
        /// </summary>
        [XmlArray("plate_no_list")]
        [XmlArrayItem("string")]
        public List<string> PlateNoList { get; set; }

        /// <summary>
        /// 必须包含街、路、村、乡、镇、道、巷、号任意一个关键词
        /// </summary>
        [XmlElement("real_property_address")]
        public string RealPropertyAddress { get; set; }

        /// <summary>
        /// 不动产使用面积，整数最长15位，小数最长10位
        /// </summary>
        [XmlElement("real_property_area")]
        public string RealPropertyArea { get; set; }

        /// <summary>
        /// 不动产权证号，无值时传“无”
        /// </summary>
        [XmlElement("real_property_cert_no")]
        public string RealPropertyCertNo { get; set; }

        /// <summary>
        /// 不动产地址所属市级行政区，必须以市、盟、自治州、地区、区任意一个关键词结尾
        /// </summary>
        [XmlElement("real_property_city")]
        public string RealPropertyCity { get; set; }

        /// <summary>
        /// 不动产自定义编码，仅支持英文字母（大写和小写）、数字、短横线（-）和下划线（_）
        /// </summary>
        [XmlElement("real_property_code")]
        public string RealPropertyCode { get; set; }

        /// <summary>
        /// 不动产地址省级行政区，必须以省、自治区、特别行政区、北京市、天津市、上海市、重庆市任意一个关键词结尾
        /// </summary>
        [XmlElement("real_property_province")]
        public string RealPropertyProvince { get; set; }

        /// <summary>
        /// 明细行号，与商品明细行号对应
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 使用开始时间，格式为yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
