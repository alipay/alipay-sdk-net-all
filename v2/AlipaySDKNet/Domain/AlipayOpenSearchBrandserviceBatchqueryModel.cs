using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBrandserviceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBrandserviceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询品牌下绑定可用类目入参
        /// </summary>
        [XmlElement("biz_data")]
        public ServiceQueryByConditionRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作的具体类型
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
