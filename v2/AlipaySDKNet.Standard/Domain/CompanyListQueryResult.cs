using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyListQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyListQueryResult : AopObject
    {
        /// <summary>
        /// 公司基础信息列表
        /// </summary>
        [XmlArray("company_base_model_list")]
        [XmlArrayItem("company_base_v_o")]
        public List<CompanyBaseVO> CompanyBaseModelList { get; set; }

        /// <summary>
        /// 公司集合
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("corp_company_v_o")]
        public List<CorpCompanyVO> Data { get; set; }

        /// <summary>
        /// 字段权限列表
        /// </summary>
        [XmlArray("field_info_list")]
        [XmlArrayItem("string")]
        public List<string> FieldInfoList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 是否分页
        /// </summary>
        [XmlElement("paging")]
        public bool Paging { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
