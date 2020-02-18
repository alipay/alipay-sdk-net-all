using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIrisCreateResponse.
    /// </summary>
    public class AlipaySecurityProdIrisCreateResponse : AopResponse
    {
        /// <summary>
        /// 虹膜注册的关联token，用于关联跨设备分次注册
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 虹膜扩展参数，用于后续扩展，目前没有内容
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 对此次插入虹膜库分组的虹膜id标识
        /// </summary>
        [XmlElement("iris_id")]
        public string IrisId { get; set; }

        /// <summary>
        /// 用于标识本次虹膜注册是否已经完成，0：初始状态，1：有person_id，16：有iris_str，17：有person_id和iris_str
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
