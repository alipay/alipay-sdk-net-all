using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNdeviceWorkUnbindResponse.
    /// </summary>
    public class AlipayOpenSpNdeviceWorkUnbindResponse : AopResponse
    {
        /// <summary>
        /// 外部业务主键ID，用来保证绑定操作重试操作下幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 当前操作是否完成
        /// </summary>
        [XmlElement("unbind_result")]
        public bool UnbindResult { get; set; }
    }
}
