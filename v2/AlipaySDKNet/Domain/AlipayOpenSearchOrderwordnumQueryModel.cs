using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchOrderwordnumQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchOrderwordnumQueryModel : AopObject
    {
        /// <summary>
        /// 搜索关键词可配置数量入参
        /// </summary>
        [XmlElement("biz_data")]
        public SearchOrderBaseKeyWordNumRequest BizData { get; set; }

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
