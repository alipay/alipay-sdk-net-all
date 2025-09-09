using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialStoreCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialStoreCreateModel : AopObject
    {
        /// <summary>
        /// 服务市场商品编号
        /// </summary>
        [XmlElement("access_code")]
        public string AccessCode { get; set; }

        /// <summary>
        /// 店铺接入模式
        /// </summary>
        [XmlElement("access_model")]
        public string AccessModel { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商家oid和owner_pid不能同时为空
        /// </summary>
        [XmlElement("owner_oid")]
        public string OwnerOid { get; set; }

        /// <summary>
        /// 商家pid和owner_oId不能同时为空
        /// </summary>
        [XmlElement("owner_pid")]
        public string OwnerPid { get; set; }

        /// <summary>
        /// 用户类型：当前场景下用户类型只有商户
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 生活号ID（非必须）
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 店铺业务ID(小程序ID)
        /// </summary>
        [XmlElement("store_biz_id")]
        public string StoreBizId { get; set; }

        /// <summary>
        /// 店铺子类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
