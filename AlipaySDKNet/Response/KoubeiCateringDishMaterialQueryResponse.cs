using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishMaterialQueryResponse.
    /// </summary>
    public class KoubeiCateringDishMaterialQueryResponse : AopResponse
    {
        /// <summary>
        /// 加料模型
        /// </summary>
        [XmlArray("kb_dish_material_info_list")]
        [XmlArrayItem("kbdish_material_info")]
        public List<KbdishMaterialInfo> KbDishMaterialInfoList { get; set; }

        /// <summary>
        /// 表示当前页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
