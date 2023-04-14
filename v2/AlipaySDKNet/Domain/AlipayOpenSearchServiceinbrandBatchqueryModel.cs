using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchServiceinbrandBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchServiceinbrandBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询品牌绑定的官方账号入参
        /// </summary>
        [XmlElement("biz_data")]
        public SearchQueryBoxExclusiveServiceInfoRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体的业务操作类型，如：create、query、cancel
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
