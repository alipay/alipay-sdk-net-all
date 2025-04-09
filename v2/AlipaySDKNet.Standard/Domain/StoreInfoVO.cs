using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class StoreInfoVO : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店经营品类,多值使用逗号分隔；
        /// </summary>
        [XmlElement("business_category")]
        public string BusinessCategory { get; set; }

        /// <summary>
        /// 门店营业时间
        /// </summary>
        [XmlElement("business_dates")]
        public BusinessDateDTO BusinessDates { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 配送类型
        /// </summary>
        [XmlElement("delivery_way")]
        public string DeliveryWay { get; set; }

        /// <summary>
        /// 环境图URL列表
        /// </summary>
        [XmlArray("env_img_list")]
        [XmlArrayItem("string")]
        public List<string> EnvImgList { get; set; }

        /// <summary>
        /// 门脸图URL
        /// </summary>
        [XmlElement("facade_img")]
        public string FacadeImg { get; set; }

        /// <summary>
        /// 门店创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 门店最近一次更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 门店维度，最高精确到小数点后6位
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店经度，最高精确到小数点后6位
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 医保国标编码
        /// </summary>
        [XmlElement("mi_code")]
        public string MiCode { get; set; }

        /// <summary>
        /// 医保国标名称
        /// </summary>
        [XmlElement("mi_name")]
        public string MiName { get; set; }

        /// <summary>
        /// 门店能否使用医保的状态
        /// </summary>
        [XmlElement("mi_state")]
        public string MiState { get; set; }

        /// <summary>
        /// 门店营业状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 门店LOGOURL
        /// </summary>
        [XmlElement("store_logo")]
        public string StoreLogo { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
