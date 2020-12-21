using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchAbilityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchAbilityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 搜索运营列表的查询request
        /// </summary>
        [XmlElement("biz_data")]
        public SearchOperPageQueryRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：query
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
