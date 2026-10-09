using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdentitylibraryTmallgoodsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdentitylibraryTmallgoodsCreateModel : AopObject
    {
        /// <summary>
        /// 异步点击监测链接
        /// </summary>
        [XmlElement("async_click_url")]
        public string AsyncClickUrl { get; set; }

        /// <summary>
        /// 异步曝光监测链接
        /// </summary>
        [XmlElement("async_exposure_url")]
        public string AsyncExposureUrl { get; set; }

        /// <summary>
        /// 天猫商品 ID（对应 outId）
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品主图 URL
        /// </summary>
        [XmlElement("main_image_url")]
        public string MainImageUrl { get; set; }

        /// <summary>
        /// 非负整数，单位：分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 灯火账户 ID（UDS 代理*商家，对应 adbase_ad_principal.id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 商家的OID
        /// </summary>
        [XmlElement("principal_oid")]
        public string PrincipalOid { get; set; }

        /// <summary>
        /// 账户鉴权标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 同步点击监测链接
        /// </summary>
        [XmlElement("sync_click_url")]
        public string SyncClickUrl { get; set; }
    }
}
