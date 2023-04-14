using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodItemRefreshModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodItemRefreshModel : AopObject
    {
        /// <summary>
        /// 支付宝的服务产品编号
        /// </summary>
        [XmlElement("ant_ser_prod_no")]
        public string AntSerProdNo { get; set; }

        /// <summary>
        /// 机构商品编码
        /// </summary>
        [XmlElement("merchant_item_code")]
        public string MerchantItemCode { get; set; }

        /// <summary>
        /// 刷新内容类型
        /// </summary>
        [XmlElement("refresh_type")]
        public string RefreshType { get; set; }
    }
}
