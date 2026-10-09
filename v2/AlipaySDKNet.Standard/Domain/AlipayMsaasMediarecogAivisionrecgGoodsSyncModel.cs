using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionrecgGoodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAivisionrecgGoodsSyncModel : AopObject
    {
        /// <summary>
        /// 商品文件
        /// </summary>
        [XmlElement("goods_data_file_url")]
        public string GoodsDataFileUrl { get; set; }

        /// <summary>
        /// 服务商ID
        /// </summary>
        [XmlElement("isv_id")]
        public string IsvId { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
    }
}
