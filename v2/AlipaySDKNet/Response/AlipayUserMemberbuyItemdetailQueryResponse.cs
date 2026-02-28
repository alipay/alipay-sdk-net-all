using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberbuyItemdetailQueryResponse.
    /// </summary>
    public class AlipayUserMemberbuyItemdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 会员购商品关联的商详URL
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 会员购商品关联的会员服务配置ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
