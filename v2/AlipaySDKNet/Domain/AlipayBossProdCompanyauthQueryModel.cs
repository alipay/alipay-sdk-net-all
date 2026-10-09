using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdCompanyauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdCompanyauthQueryModel : AopObject
    {
        /// <summary>
        /// 对应云凤蝶表单中填写的appCode
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 公司id查询
        /// </summary>
        [XmlElement("company_id_list")]
        public string CompanyIdList { get; set; }

        /// <summary>
        /// 公司名精确查询
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司名称模糊查询
        /// </summary>
        [XmlElement("company_name_fuzzy")]
        public string CompanyNameFuzzy { get; set; }

        /// <summary>
        /// ouCode精准查询
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 传boolean值
        /// </summary>
        [XmlElement("paging")]
        public bool Paging { get; set; }

        /// <summary>
        /// 对应云凤蝶表单中填写的场景 前面这个字符串
        /// </summary>
        [XmlElement("usage_scene")]
        public string UsageScene { get; set; }
    }
}
