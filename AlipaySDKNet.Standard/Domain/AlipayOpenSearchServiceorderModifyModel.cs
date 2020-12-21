using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchServiceorderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchServiceorderModifyModel : AopObject
    {
        /// <summary>
        /// 创建搜索运营申请单的入参
        /// </summary>
        [XmlElement("biz_data")]
        public SearchOrderCreateRequest BizData { get; set; }

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
