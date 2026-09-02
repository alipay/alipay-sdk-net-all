using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountAcccoreCetifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountAcccoreCetifyQueryModel : AopObject
    {
        /// <summary>
        /// 目标查询账户的id，作为路由和查询账户使用
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 查询场景，后续区分不同场景查询
        /// </summary>
        [XmlElement("query_scene")]
        public string QueryScene { get; set; }
    }
}
