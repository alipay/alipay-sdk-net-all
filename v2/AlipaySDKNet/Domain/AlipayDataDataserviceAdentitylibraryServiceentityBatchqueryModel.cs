using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdentitylibraryServiceentityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdentitylibraryServiceentityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页的页码
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 灯火定义的营销目标对应的code值
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 每页返回的数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家的id，用于唯一标识一个商家
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 商品所属的小程序appId
        /// </summary>
        [XmlElement("service_entity_app_id")]
        public string ServiceEntityAppId { get; set; }

        /// <summary>
        /// 用于表示实体来源
        /// </summary>
        [XmlElement("service_entity_out_source")]
        public string ServiceEntityOutSource { get; set; }

        /// <summary>
        /// 标识实体的类型，可以是电商商品、金融商品、保险服务三种类型
        /// </summary>
        [XmlElement("service_entity_type")]
        public string ServiceEntityType { get; set; }
    }
}
