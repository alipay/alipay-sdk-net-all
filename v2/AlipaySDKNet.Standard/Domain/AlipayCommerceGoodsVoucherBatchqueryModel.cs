using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGoodsVoucherBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGoodsVoucherBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("goods_list")]
        public BizfmcgGoods GoodsList { get; set; }

        /// <summary>
        /// isvId
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
