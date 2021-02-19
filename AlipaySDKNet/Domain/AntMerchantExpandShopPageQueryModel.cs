using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopPageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopPageQueryModel : AopObject
    {
        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。特别说明：IoT设备三绑定场景统一填写商户pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 查询页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询大小，限制100以内
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
