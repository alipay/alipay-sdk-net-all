using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBrandboxQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBrandboxQueryModel : AopObject
    {
        /// <summary>
        /// 品牌box详情查询入参
        /// </summary>
        [XmlElement("biz_data")]
        public SearchBrandBoxRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体的操作类型，如creat、mod、query
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
