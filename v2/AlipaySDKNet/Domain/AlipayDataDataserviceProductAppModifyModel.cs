using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceProductAppModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceProductAppModifyModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商品类型，由灯火系统分配给商家
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 商家侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品来源，油灯火系统分配给商户
        /// </summary>
        [XmlElement("out_source")]
        public string OutSource { get; set; }

        /// <summary>
        /// 商品归属的商户oid, 传入oid时优先使用oid，否则使用pid
        /// </summary>
        [XmlElement("owner_oid")]
        public string OwnerOid { get; set; }

        /// <summary>
        /// 商品归属的商户pid
        /// </summary>
        [XmlElement("owner_pid")]
        public string OwnerPid { get; set; }

        /// <summary>
        /// 商家在支付宝数字推广平台唯一标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 商品归属小程序id
        /// </summary>
        [XmlElement("prod_app_id")]
        public string ProdAppId { get; set; }

        /// <summary>
        /// 商品原始状态
        /// </summary>
        [XmlElement("src_status")]
        public string SrcStatus { get; set; }
    }
}
