using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantCbuprofileSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantCbuprofileSubmitModel : AopObject
    {
        /// <summary>
        /// 渠道商侧用户唯一ID，1688商户使用aliId
        /// </summary>
        [XmlElement("ali_id")]
        public string AliId { get; set; }

        /// <summary>
        /// 用户在渠道侧选择的企业类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("cooperation_model")]
        [XmlArrayItem("string")]
        public List<string> CooperationModel { get; set; }

        /// <summary>
        /// 主营一级类目名称
        /// </summary>
        [XmlElement("main_cate_1_name")]
        public string MainCate1Name { get; set; }

        /// <summary>
        /// 主营二级类目名称
        /// </summary>
        [XmlElement("main_cate_2_name")]
        public string MainCate2Name { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sale_channels")]
        [XmlArrayItem("string")]
        public List<string> SaleChannels { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("target_customer_type")]
        [XmlArrayItem("string")]
        public List<string> TargetCustomerType { get; set; }
    }
}
