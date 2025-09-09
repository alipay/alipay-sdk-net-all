using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingOrginfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingOrginfoModifyModel : AopObject
    {
        /// <summary>
        /// 机构地址\考评组织地点
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 机构简介\考评组织描述。 type=rating_org必填 
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 机构主页链接，小程序链接
        /// </summary>
        [XmlElement("index_link")]
        public string IndexLink { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 必须是调用alipay.marketing.image.enhance.upload(营销图片优化上传接口)(upload_scene= ITEM_BRAND_LOGO_IMAGE) 接口上传返回的营销图片链接
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 机构名称\评价组织名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 机构类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
