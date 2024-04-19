using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserJobcardJobsupplierQueryResponse.
    /// </summary>
    public class AlipayUserJobcardJobsupplierQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业基本信息。各参数含义 employ_nums：公司规模人数； registered_captial：注册资金； esta_date：成立时间； nature：公私营性质；
        /// </summary>
        [XmlElement("basic_info")]
        public string BasicInfo { get; set; }

        /// <summary>
        /// 企业福利补贴
        /// </summary>
        [XmlElement("bonus_desc")]
        public string BonusDesc { get; set; }

        /// <summary>
        /// 所属行业名称
        /// </summary>
        [XmlElement("industry_name")]
        public string IndustryName { get; set; }

        /// <summary>
        /// 职位供应商介绍
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 岗位信息列表
        /// </summary>
        [XmlArray("job_info_list")]
        [XmlArrayItem("job_info")]
        public List<JobInfo> JobInfoList { get; set; }

        /// <summary>
        /// 职位供应商code
        /// </summary>
        [XmlElement("job_supplier_code")]
        public string JobSupplierCode { get; set; }

        /// <summary>
        /// 地理位置信息，ISV可根据此信息获取定位展示。各参数含义 longitude：经度； latitude：纬度； address_name：定位名称； address_desc：地址展示名称；
        /// </summary>
        [XmlElement("location_info")]
        public string LocationInfo { get; set; }

        /// <summary>
        /// 职位供应商名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 供应商页面展示相关素材信息
        /// </summary>
        [XmlElement("page_info")]
        public string PageInfo { get; set; }

        /// <summary>
        /// 岗位供应商状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 供应商类型。 ENTERPRISES：企业； STORE:门店
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 是否芝麻认证企业 true：是 false：认证不通过或未认证
        /// </summary>
        [XmlElement("zhima_cert")]
        public bool ZhimaCert { get; set; }

        /// <summary>
        /// 芝麻认证企业页面url
        /// </summary>
        [XmlElement("zhima_cert_url")]
        public string ZhimaCertUrl { get; set; }
    }
}
