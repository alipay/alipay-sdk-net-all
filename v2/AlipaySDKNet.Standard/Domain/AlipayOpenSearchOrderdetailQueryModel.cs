using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchOrderdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchOrderdetailQueryModel : AopObject
    {
        /// <summary>
        /// 查询申请单详情的入参
        /// </summary>
        [XmlElement("biz_data")]
        public SearchOrderRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：create、mod、cancel
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
