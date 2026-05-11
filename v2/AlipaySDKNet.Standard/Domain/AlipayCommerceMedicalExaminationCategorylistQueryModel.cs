using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalExaminationCategorylistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalExaminationCategorylistQueryModel : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 检查类目类型:CHECK_CATEGORY、 检验类目类型：INSPECTION_CATEGORY 不传，默认查全部
        /// </summary>
        [XmlElement("category_state")]
        public string CategoryState { get; set; }

        /// <summary>
        /// 类目状态
        /// </summary>
        [XmlElement("category_type")]
        public string CategoryType { get; set; }

        /// <summary>
        /// query_type 查询类型 ? all：全部数据 ? primary：按一级分类查询 ? secondary：按二级分类查询 ? three：按三级分类查询
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
