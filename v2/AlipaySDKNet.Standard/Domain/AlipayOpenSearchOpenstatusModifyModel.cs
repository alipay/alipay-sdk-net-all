using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchOpenstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchOpenstatusModifyModel : AopObject
    {
        /// <summary>
        /// 修改运营服务的上下架请求入参
        /// </summary>
        [XmlElement("biz_data")]
        public SearchOpenStatusRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：mod
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
